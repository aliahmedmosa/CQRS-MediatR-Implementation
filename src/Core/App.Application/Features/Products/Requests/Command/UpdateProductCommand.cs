namespace App.Application.Features.Products.Requests.Command
{
    public class UpdateProductCommand : IRequest<Unit>
    {
        public ProductDto ProductDto { get; set; }
    }
}
