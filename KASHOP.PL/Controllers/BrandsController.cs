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
    public class BrandController : ControllerBase
    {
        GenericRepository<Brand> repo = new GenericRepository<Brand>();
        [HttpGet("")]
        public IActionResult Index()
        {
            var brands = repo.Get();
            return Ok(brands);
        }

     //   [HttpGet("{id}")]
      //  public IActionResult GetById(int id)
      //  {
     //       var brand = context.Brands.Find(id);
     //       return Ok(brand);
     //   }
        [HttpPost("")]
        public IActionResult Add(Brand brand)
        {
            repo.Create(brand);
            return Ok();
        }
    }
}
