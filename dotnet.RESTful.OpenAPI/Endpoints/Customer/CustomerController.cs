using dotnet.RESTful.OpenAPI.Endpoints.Customer.Post;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace dotnet.RESTful.OpenAPI.Endpoints.Customer
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CustomerController(IMediator mediator) => _mediator = mediator;

        /// <summary/>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult> AddCustomer([FromBody] Customer customer)
        {
            var productToReturn = await _mediator.Send(new CreateCustomerCommand(customer));

            return CreatedAtRoute(new { id = productToReturn.Id }, productToReturn);
        }
    }
}
