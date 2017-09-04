using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace POSMachine.controller
{
    public class POSMachineController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage GetRecipt([FromBody]string barcodes)
        {
            if (String.IsNullOrEmpty(barcodes))
            {
                return Request.Text(HttpStatusCode.BadRequest,"");
            }
            return Request.Text(HttpStatusCode.OK, "");
        }
    }
}
