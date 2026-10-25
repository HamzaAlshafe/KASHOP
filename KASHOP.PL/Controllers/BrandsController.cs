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
        private readonly IGenericRepository<Brand> _repository;
        public BrandController(IGenericRepository<Brand> repository)
        {
            _repository = repository;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            var brands = _repository.GetAsync();
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
            _repository.CreateAsync(brand);
            return Ok();
        }
    }
}
