using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_Trial.Controllers
{
    public class AssetController : ApiController
    {
        public string GetCompanyNameByCompanyID(string companyID)
        {
            return "ABC";
        }
    }
}