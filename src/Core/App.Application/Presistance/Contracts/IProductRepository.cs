namespace App.Application.Presistance.Contracts
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<List<Product>> GetAllAsyncWithInclude();
    }
}
