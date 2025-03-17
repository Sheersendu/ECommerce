namespace Ecommerce.Modules.Product;

public interface IProductRepository
{
	public Task<Product> GetProduct(Guid productId);
	
	public void AddProduct(Product product);
}