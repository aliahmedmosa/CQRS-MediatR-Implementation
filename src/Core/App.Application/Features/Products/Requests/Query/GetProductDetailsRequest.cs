namespace App.Application.Features.Products.Requests.Query
{
    public class GetProductDetailsRequest : IRequest<ProductDto>
    {
        public int Id { get; set; }
    }
}
