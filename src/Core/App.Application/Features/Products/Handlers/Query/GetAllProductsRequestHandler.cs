namespace App.Application.Features.Products.Handlers.Query
{
    public class GetAllProductsRequestHandler : IRequestHandler<GetAllProductsRequest, List<ProductDto>>
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public GetAllProductsRequestHandler(IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<List<ProductDto>> Handle(GetAllProductsRequest request, CancellationToken cancellationToken)
        {
            var products = await _repository.GetAllAsyncWithInclude();
            var res = _mapper.Map<List<ProductDto>>(products);
            return res;
        }
    }
}
