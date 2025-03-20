using Ecommerce.Infrastructure;

namespace Ecommerce.Modules.Product;

public class ProductRepository : IProductRepository
{
	private Dictionary<Guid, Domain.Entities.Product> products;
	private readonly AppDbContext _context;
	public ProductRepository(AppDbContext context)
	{
		products = new Dictionary<Guid, Domain.Entities.Product>();
		_context = context;
		Console.WriteLine(_context);
	}

	public async Task<Domain.Entities.Product> GetProduct(Guid productId)
	{
		if (products.ContainsKey(productId))
		{
			return products.GetValueOrDefault(productId);
		}

		return new Domain.Entities.Product();
	}
	public async Task<Domain.Entities.Product> AddProduct(ProductInputDTO product)
	{
		Guid productId = Guid.NewGuid();
		Domain.Entities.Product newProduct = new()
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