using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using AngularTest.Data;
using AngularTest.Models;

namespace AngularTest.Services
{
    public class LabOrderService
    {
        AngularTestEntities dbContext = new AngularTestEntities();
        public async Task<List<LabOrderListViewModel>> GetLabOrderList()
        {

            var test = dbContext.LabOrders.FirstOrDefault();
            //Query List from Context
            var result = dbContext.LabOrders.Join(dbContext.LabTests, lo => lo.LabTestId, lt => lt.Id, (lo, lt) =>  new LabOrderListViewModel
            {
                Id = lo.Id,
                LabTestName = lt.LabTestName,
                OrderDate = lo.OrderDate,
                AmountBilled = lo.AmountBilled,
                AmountCollected = lo.AmountCollected
            }).OrderByDescending(l => l.OrderDate);
            return await result.ToListAsync();
        }
    }
}