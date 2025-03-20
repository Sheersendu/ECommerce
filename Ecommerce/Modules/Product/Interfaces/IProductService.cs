namespace Ecommerce.Modules.Product;

public interface IProductService
{
	public Task<Domain.Entities.Product> GetProduct(Guid productId);
	public Task<Domain.Entities.Product> AddProduct(ProductInputDTO product);
}