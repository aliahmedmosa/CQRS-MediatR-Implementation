using App.Application.Features.Categories.Requests.Query;
namespace App.Application.Features.Categories.Handlers.Query
{
    public class GetAllCatedoriesRequestHandler : IRequestHandler<GetAllCatedoriesRequest, List<CategoryDto>>
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;

        public GetAllCatedoriesRequestHandler(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<List<CategoryDto>> Handle(GetAllCatedoriesRequest request, CancellationToken cancellationToken)
        {
            var categories = await _repository.GetAllAsync();
            var res = _mapper.Map<List<CategoryDto>>(categories);
            return res;
        }
    }
}
