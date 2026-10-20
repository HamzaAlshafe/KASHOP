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
       private readonly IGenericRepository<Category> _repositroy;
        CategoriesController(IGenericRepository<Category> repositroy) {
            _repositroy = repositroy;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            var categories = _repositroy.Get();
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
            _repositroy.Create(category);
            return Ok();
        }
    }
}
