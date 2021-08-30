using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myWebApiProject.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //[Route("api/get-all")]
        //[Route("getall")]
        //[Route("get-all")]
        //[Route("[controller]/[action]")]
        //overrite : //[Route("~/get-all")]
        public string GetAll() {
            return "Hello from get All";
        }

        //[Route("api/get-all-authors")]
        //[Route("getall")] this is not possible
        public string GetAllAuthors()
        {
            return "Hello from get All authors";
        }

        //[Route("books/{id}/author/{authorId}")]
        [Route("{id}")]
        public string GetById(int id ,int authorId)
        {
            return "Hello : " + id + " author Id = " + authorId;
        }


        //[Route("search")]
        public string SearchBooks(int id, int authorId, string name, int rating, int price)
        {
            return "Hello : " + id + " author Id = " + authorId+ " name  = "+name;
        }
    }
}
