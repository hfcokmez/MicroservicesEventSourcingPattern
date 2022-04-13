using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventSourcing.API.Commands;
using EventSourcing.API.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;
 
namespace EventSourcing.API.Controllers
{
    [Route("api/[controller]/[action]")]
    public class ProductsController : Controller
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateProductDTO createProductDTO)
        {


                await _mediator.Send(new CreateProductCommand() { CreateProductDto = createProductDTO });
           
            return NoContent();
        }
        [HttpPut]
        public async Task<IActionResult> ChangeName(ChangeProductNameDTO changeProductNameDTO)
        {
            await _mediator.Send(new ChangeProductNameCommand() { ChangeProductNameDTO = changeProductNameDTO });
            return NoContent();
        } 
        [HttpPut]
        public async Task<IActionResult> ChangePrice(ChangeProductPriceDTO changeProductPriceDTO)
        {
            await _mediator.Send(new ChangeProductPriceCommand() { ChangeProductPriceDTO = changeProductPriceDTO });
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _mediator.Send(new DeleteProductCommand() { Id = id });
            return NoContent();
        }

    }
}
