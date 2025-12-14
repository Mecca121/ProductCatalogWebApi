using ProductCatalogWebApi.Models;

namespace ProductCatalogWebApi.Abstractions
{
    public interface ICartRepository
    {
        Task<Cart?> GetByIdAsync(Guid id, CancellationToken ct);
        Task DeleteAsync(Cart cart, CancellationToken ct);
    }
}