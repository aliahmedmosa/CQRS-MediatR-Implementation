namespace App.Application.Features.Products.Requests.Command
{
    public class CreateProductCommand : IRequest<Unit>
    {
        public ProductDto ProductDto { get; set; }
    }
}
