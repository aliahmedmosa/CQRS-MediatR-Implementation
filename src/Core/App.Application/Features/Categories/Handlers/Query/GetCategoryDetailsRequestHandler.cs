using App.Application.Features.Categories.Requests.Query;

namespace App.Application.Features.Categories.Handlers.Query
{
    public class GetCategoryDetailsRequestHandler : IRequestHandler<GetCategoryDetailsRequest, CategoryDto>
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;

        public GetCategoryDetailsRequestHandler(ICategoryRepository repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<CategoryDto> Handle(GetCategoryDetailsRequest request, CancellationToken cancellationToken)
        {
            var category =await _repository.GetAsync(request.Id);
            if (category is null)
                throw new Exception();
            return _mapper.Map<CategoryDto>(category);
        }
    }
}
