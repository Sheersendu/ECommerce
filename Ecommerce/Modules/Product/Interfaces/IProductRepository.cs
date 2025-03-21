using Ecommerce.Modules.Product;

namespace Ecommerce.Modules;

public interface IProductRepository
{
	public Task<Domain.Entities.Product> GetProduct(Guid productId);
	
	public Task<Domain.Entities.Product> AddProduct(ProductInputDTO product);
	
	public Task<Domain.Entities.Product> UpdateProduct(Guid productId, ProductInputDTO product);
}