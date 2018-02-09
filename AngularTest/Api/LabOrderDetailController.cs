using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using AngularTest.Models;
using AngularTest.Services;
using Newtonsoft.Json.Linq;

namespace AngularTest.Api
{
    public class LabOrderDetailController : ApiController
    {
        private readonly LabOrderDetailsService _service = new LabOrderDetailsService();

        // GET api/LabOrderDetail/{id}
        [HttpGet]
        public async Task<LabOrderDetailsViewModel> Get([FromUri] int id)
        {
            var result = await _service.GetLabOrderDetails(id);
            return result;
        }

        [HttpPost]
        public async Task<bool> Update(LabOrderDetailsSaveModel response)
        {
            var isSuccessful = await _service.UpdateLabOrderDetails(response);
            return isSuccessful;
        }
    }
}