namespace ProductCatalogWebApi.Abstractions
{
    public interface ICurrentUserService
    {
        string? UserId { get; }
    }
}