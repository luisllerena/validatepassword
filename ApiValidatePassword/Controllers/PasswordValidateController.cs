using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ApiValidatePassword.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PasswordValidateController : ControllerBase
    {
        //private readonly IConfiguration configuration;

        public PasswordValidateController()
        {

            string conexion = Startup.ConnectionString;
            DAL.PasswordDAL inter = new DAL.PasswordDAL();
            inter.GetPasswordConditions("djks", conexion);
            //configuration = config;
            //string connectionString = configuration.GetConnectionString("cadena");
        }
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {           
            return new string[] { "value1", "value2" };
        }
    }
}