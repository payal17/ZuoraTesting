using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class ZuoraController : ApiController
    {
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/Zuora/GetDetails")]
        public ZuoraModel GetDetails()
        {
            ZuoraModel z = new ZuoraModel();
            z.message = "message came";
            z.success = true;
            return z;
        }
    }
}
