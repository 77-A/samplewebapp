using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace SampleWebApi.Controllers
{
    [Route("api/SampleController")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public SampleController(
            IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet()]
        public ActionResult<string> Get(string name)
        {
            return new OkObjectResult(_configuration[name]);
        }
    }
}
