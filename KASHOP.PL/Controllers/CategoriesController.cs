using KASHOP.BLL;
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
       private readonly ICategoryService _service;
        public CategoriesController(ICategoryService service) {
            _service = service;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            var categories = _service.GetAll();
            return Ok(categories);
        }

        //[HttpGet("{id}")]
       // public IActionResult GetById(int id)
        //{
        //    var category = context.Categories.Find(id);
        //    return Ok(category);
        //}
        //[HttpPost("")]
        //public IActionResult Add(Category category)
        //{
        //    _service.Create(category);
        //    return Ok();
        //}
    }
}
