using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Notifications;

namespace apiBaseCore.Controllers
{
    [Route("api/home")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        [HttpPost , Route("testslack")]
        public string TestSlack()
        {          
            
            using (var client = new SlackClient())
            {
                string msj = "testiando notificacion slack";
                string canalSlack = "#cashflow_testing";

                return client.PostMessage(msj, "", canalSlack);
            }            
        }

        public string GetEmployeeName(int empId)
        {
            string name;
            if (empId == 1)
            {
                name = "Jignesh";
            }
            else if (empId == 2)
            {
                name = "Rakesh";
            }
            else
            {
                name = "Not Found";
            }
            return name;
        }
    }
}