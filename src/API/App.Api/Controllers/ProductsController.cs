using App.Application.DTOs.EntitiesDto;
using App.Application.Features.Categories.Requests.Command;
using App.Application.Features.Products.Requests.Command;
using App.Application.Features.Products.Requests.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace App.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetProducts")]
        public async Task<IActionResult> Get()
        {
            var command = await _mediator.Send(new GetAllProductsRequest());
            return Ok(command);
        }

        [HttpGet("GetProductsById/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var command = await _mediator.Send(new GetProductDetailsRequest { Id = id });
            return Ok(command);
        }

        [HttpPost("CreateNewProduct")]
        public async Task<IActionResult> Post([FromBody] ProductDto productDto)
        {
            var command = new CreateProductCommand { ProductDto = productDto };
            var response = await _mediator.Send(command);
            return Ok(response);

        }

        [HttpPut("UpdateProduct")]
        public async Task<IActionResult> Put([FromBody] ProductDto productDto)
        {
            var command = new UpdateProductCommand { ProductDto = productDto };
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("DeleteProduct/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteProductCommand { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
