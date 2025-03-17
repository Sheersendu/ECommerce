namespace Ecommerce.Modules.Product;

public interface IProductService
{
	public Task<Product> GetProduct(Guid productId);
	public Task<Product> AddProduct(ProductInputDTO product);
}