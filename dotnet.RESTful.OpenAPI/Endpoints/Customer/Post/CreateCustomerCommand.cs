using MediatR;

namespace dotnet.RESTful.OpenAPI.Endpoints.Customer.Post
{
    public record CreateCustomerCommand(Customer customer) : IRequest<Customer>;

}
