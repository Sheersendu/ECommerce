namespace Ecommerce.Modules.Product;

public class ProductRepository : IProductRepository
{
	private Dictionary<Guid, Product> products;
	public ProductRepository()
	{
		products = new Dictionary<Guid, Product>();
	}

	public async Task<Product> GetProduct(Guid productId)
	{
		if (products.ContainsKey(productId))
		{
			return products.GetValueOrDefault(productId);
		}

		return new Product();
	}
	public async Task<Product> AddProduct(ProductInputDTO product)
	{
		Guid productId = Guid.NewGuid();
		Product newProduct = new()
		{
			Id = productId,
			Name = product.Name,
			Description = product.Description,
			Price = product.Price,
			CreatedTimeStamp = DateTime.Now
		};
		products.Add(productId, newProduct);
		return newProduct;
	}
}