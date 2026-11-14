using KASHOP.BLL;
using KASHOP.DAL.DTO.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KASHOP.PL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController (IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var result = await _productService.GetAllAsync(cancellationToken);

            return Ok(result);
        }
        [HttpPost("")]

        public async Task<IActionResult> Create([FromForm] ProductRequest request, CancellationToken cancellationToken)
        {
            var result = await _productService.CreateAsync(request, cancellationToken);
            
            return result ? Ok() : BadRequest("Invalid product data");
        }
    }
}
