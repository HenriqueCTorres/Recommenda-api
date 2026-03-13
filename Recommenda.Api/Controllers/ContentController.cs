using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Recommenda.Application.DTOs;
using Recommenda.Application.Services;

namespace Recommenda.Api.Controllers
{
    //api/content - POST
    [Route("api/[controller]")]
    [ApiController]
    public class ContentController : ControllerBase
    {
        //Get
        //Post
        //Delete
        //Path
        
        [HttpPost]
        public IActionResult Create(ContentRequest contentRequest)
        {
            //var x = contentRequest.ToDomain();
            Console.WriteLine("O POST CHEGOU");
            
            ContentService contentService = new ContentService();
            var contentResponse = contentService.Create(contentRequest);
            
            return Created("", contentResponse);
        }
    }
}
