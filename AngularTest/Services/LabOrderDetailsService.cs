using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using AngularTest.Api;
using AngularTest.Data;
using AngularTest.Models;

namespace AngularTest.Services
{
    public class LabOrderDetailsService
    {
        AngularTestEntities dbContext = new AngularTestEntities();
        public async Task<LabOrderDetailsViewModel> GetLabOrderDetails(int id)
        {
            var result = dbContext.LabOrders
                .Join(dbContext.Patients, lo => lo.PatientId, p => p.Id, (lo, p) => new { lo, p })
                .Join(dbContext.Facilities, lo2 => lo2.lo.FacilityId, f => f.Id, (lo2, f) => new { lo2, f })
                .Join(dbContext.LabTests, lo3 => lo3.lo2.lo.LabTestId, lt => lt.Id,
                    (lo3, lt) => new LabOrderDetailsViewModel
                    {
                        Id = lo3.lo2.lo.Id,
                        LabTestName = lt.LabTestName,
                        PatientFirstName = lo3.lo2.lo.Patient.FirstName,
                        PatientLastName = lo3.lo2.lo.Patient.LastName,
                        OrderDate = lo3.lo2.lo.OrderDate,
                        FacilityName = lo3.f.FacilityName,
                        AmountCollected = lo3.lo2.lo.AmountCollected
                    });

            return await result.SingleOrDefaultAsync(r => r.Id == id);
        }

        public async Task<bool> UpdateLabOrderDetails(LabOrderDetailsSaveModel model)
        {
            try
            {
                var labOrder = dbContext.LabOrders.SingleOrDefaultAsync(l => l.Id == model.Id);
                labOrder.Result.AmountCollected = model.AmountCollected;
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}