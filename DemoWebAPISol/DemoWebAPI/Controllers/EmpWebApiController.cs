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

        [HttpGet]
        [Route("GetNumbers")]
        public IActionResult GetNumbers()
        {
            try
            {
                List<int> Nos = new List<int>();
                Nos.Add(100);
                Nos.Add(120);
                Nos.Add(140);
                Nos.Add(160);
                Nos.Add(180);

                return Ok(Nos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }
    }
}
