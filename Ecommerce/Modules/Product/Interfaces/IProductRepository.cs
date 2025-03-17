namespace Ecommerce.Modules.Product;

public interface IProductRepository
{
	public Task<Product> GetProduct(Guid productId);
	
	public Task<Product> AddProduct(ProductInputDTO product);
}