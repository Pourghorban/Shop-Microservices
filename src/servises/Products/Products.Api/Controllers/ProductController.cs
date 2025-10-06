using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Products.Application.Products.Commands.Create;
using Products.Application.Products.Commands.Delete;
using Products.Application.Products.Commands.Update;
using Products.Application.Products.Queries.GetProducts;
using Products.Application.Products.Queries.GetProductsList;
using Products.Domain;
using Products.Domain.Products;
using Products.Domain.Products.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Products.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IMediator _mediator;
        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }
        //// GET: api/<ProductController>
        [HttpGet]
        public async Task<List<ProductResDto>> Get()
        {
         
            return await _mediator.Send(new GetProductsListQuery());
        }

        // Replace the existing GetProductById method with a cleaner version
        [HttpGet("{id}")]
        public async Task<ProductResDto> GetProductById(int id)
        {
            return await _mediator.Send(new GetProductsQuery(id));
        }

        // POST api/<ProductController>
        [HttpPost]
        public async Task<ProductResDto> Post(AddProductCommand command)
        {
            return await _mediator.Send(command);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<bool>> Put(int id, UpdateProductCommand request)
        {
            if (id != request.Id)
            {

                return BadRequest("Id in body and query must be equal");
            }
            var res = await _mediator.Send(request);
            return res;

        }

        // DELETE api/<ProductController>/5
        [HttpDelete]
        public async Task<bool> Delete(DeleteProductCommand request)
        {
            var res = await _mediator.Send(request);
            return res;
        }
    }
}
