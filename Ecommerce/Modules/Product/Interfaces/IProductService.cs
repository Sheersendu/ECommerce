namespace Ecommerce.Modules.Product;

public interface IProductService
{
	public Task<Product> GetProduct(Guid productId);
	public void AddProduct(Product product);
}