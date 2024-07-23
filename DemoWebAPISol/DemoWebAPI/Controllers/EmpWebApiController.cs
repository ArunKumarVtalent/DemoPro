using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpWebApiController : ControllerBase
    {
        [HttpGet]
        [Route("GetNames")]
        public IActionResult GetNames()
        {
            try
            {
                List<string> Names = new List<string>();
                Names.Add("Virat");
                Names.Add("Rohit");
                Names.Add("Surya");
                Names.Add("Jaddu");
                Names.Add("Shikar");

                return Ok(Names);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }
    }
}
