namespace Ecommerce.Modules.Product;

public class ProductService(IProductRepository productRepository) : IProductService
{
	public async Task<Product> GetProduct(Guid productId)
	{
		return await productRepository.GetProduct(productId);
	}
	public async Task<Product> AddProduct(ProductInputDTO product)
	{
		return await productRepository.AddProduct(product);
	}
}