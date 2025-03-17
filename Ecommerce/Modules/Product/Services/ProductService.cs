namespace Ecommerce.Modules.Product;

public class ProductService(IProductRepository productRepository) : IProductService
{
	public async Task<Product> GetProduct(Guid productId)
	{
		return await productRepository.GetProduct(productId);
	}
	public void AddProduct(Product product)
	{
		productRepository.AddProduct(product);
	}
}