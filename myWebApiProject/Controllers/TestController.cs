using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myWebApiProject.Controllers
{
    [ApiController]
    [Route("test/[action]")]
    public class TestController : ControllerBase
    {//https://localhost:44381/test

        public string Get() =>
             "hello world";

        public string Get2() =>
            "hello world22222";

    }
}
