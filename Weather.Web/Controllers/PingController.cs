using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Weather.Web.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PingController : ControllerBase
    {
        [HttpGet("TestGet")]
        public IActionResult TestGet() 
        {
            var testResponse = new
            {
                Name = "Viktor",
                Age = 12
            };

            return Ok(testResponse);
        }

        [HttpGet("TestGetWithRoute/{id}")]
        public IActionResult TestGetWithRoute([FromRoute] int id)
        {
            var testResponse = new
            {
                Name = "Viktor",
                Age = id
            };

            return Ok(testResponse);
        }

        [HttpGet("TestGetWithQuery")]
        public IActionResult TestGetWithQuery([FromQuery] int id)
        {
            var testResponse = new
            {
                Name = "Viktor",
                Age = id
            };

            return Ok(testResponse);
        }

        [HttpPost("TestPost")]
        public IActionResult TestPost([FromBody]PostRequestModel postRequest)
        {

            return Ok(postRequest);
        }


    }

    public class PostRequestModel 
    {
        public string? FullName { get; set; }
        public string? Company { get; set; }
    }
}
