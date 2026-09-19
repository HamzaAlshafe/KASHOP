using KASHOP.DAL.Data;
using KASHOP.DAL.Models;
using KASHOP.DAL.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KASHOP.PL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();
        [HttpGet("")]
        public IActionResult Index()
        {
            var categories = repo.Get();
            return Ok(categories);
        }

        //[HttpGet("{id}")]
       // public IActionResult GetById(int id)
        //{
        //    var category = context.Categories.Find(id);
        //    return Ok(category);
        //}
        [HttpPost("")]
        public IActionResult Add(Category category)
        {
            repo.Create(category);
            return Ok();
        }
    }
}
