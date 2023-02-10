using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIVersioning.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/{v:apiVersion}/employee")]
    public class EmployeeV1Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return new OkObjectResult("employees from v1 controller");

            // https://localhost:44381/api/1.0/employee  URL based versioning
            //query string based versioning https://localhost:44341/api/1.0/employee?api-version=1.0
        }
    }
}
