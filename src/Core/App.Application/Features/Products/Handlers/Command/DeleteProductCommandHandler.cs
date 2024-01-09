using App.Application.Features.Products.Requests.Command;

namespace App.Application.Features.Products.Handlers.Command
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand>
    {
        private readonly IProductRepository _repository;

        public DeleteProductCommandHandler(IProductRepository repository)
        {
            _repository = repository;
        }
        public async Task<Unit> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var oldProduct = await _repository.GetAsync(request.Id);
            await _repository.DeleteAsync(oldProduct.Id);
            return Unit.Value;
        }
    }
}
