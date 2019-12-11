using POS.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace POS.Controllers
{
    public class CustomerApiController : ApiController
    {
        [HttpGet]
        public DataTable list_Cust()
        {
            Customer oBank = new Customer(CommonData.ConStr());
            return oBank.List_User();
        }


    }
}
