using App.Application.Features.Products.Requests.Command;

namespace App.Application.Features.Products.Handlers.Command
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, Unit>
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public UpdateProductCommandHandler(IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var oldProduct = await _repository.GetAsync(request.ProductDto.Id);
            var res = _mapper.Map(request.ProductDto, oldProduct);
            await _repository.UpdateAsync(res);
            return Unit.Value;
        }
    }
}
