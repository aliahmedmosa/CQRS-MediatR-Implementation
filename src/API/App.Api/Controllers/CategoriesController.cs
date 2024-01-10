using App.Application.DTOs.EntitiesDto;
using App.Application.Features.Categories.Requests.Command;
using App.Application.Features.Categories.Requests.Query;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetAllCategories")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _mediator.Send(new GetAllCatedoriesRequest()));
        }

        [HttpGet("GetCategoryById/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _mediator.Send(new GetCategoryDetailsRequest { Id = id }));
        }

        [HttpPost("CreateNewCategory")]
        public async Task<IActionResult> Post([FromBody] CategoryDto categoryDto)
        {
            return Ok(await _mediator.Send(new CreateCategoryCommand { CategoryDto = categoryDto }));
        }

        [HttpPut("UpdateCategory")]
        public async Task<IActionResult> Put([FromBody] CategoryDto categoryDto)
        {
            var command = new UpdateCategoryCommand { CategoryDto = categoryDto };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpDelete("DeleteCategory/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteCategoryCommand { Id = id };
            var response = await _mediator.Send(command);
            return NoContent();
        }
    }
}
