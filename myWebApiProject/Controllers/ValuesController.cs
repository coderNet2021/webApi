using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myWebApiProject.Controllers
{
   // [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [Route("api/get-all")]
        public string GetAll() {
            return "Hello from get All";
        }

        [Route("api/get-all-authors")]
        public string GetAllAuthors()
        {
            return "Hello from get All authors";
        }

        [Route("books/{id}")]
        public string GetById(int id)
        {
            return "Hello : "+id;
        }

    }
}
