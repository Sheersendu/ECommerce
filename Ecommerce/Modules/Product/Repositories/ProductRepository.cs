using Ecommerce.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Modules.Product;

public class ProductRepository : IProductRepository
{
	private readonly AppDbContext _context;
	public ProductRepository(AppDbContext context)
	{
		_context = context;
	}

	public async Task<Domain.Entities.Product> GetProduct(Guid productId)
	{
		var existingProduct = await _context.Products.FindAsync(productId);
		return existingProduct ?? new Domain.Entities.Product();
	}
	
	public async Task<Domain.Entities.Product> AddProduct(ProductInputDTO product)
	{
		Domain.Entities.Product newProduct = new()
		{
			Id = Guid.NewGuid(),
			Name = product.Name,
			Description = product.Description,
			Price = product.Price,
			CategoryId = product.CategoryId,
			Quantity = product.Quantity,
			CreatedTimeStamp = DateTime.UtcNow
		};
		
		_context.Products.Add(newProduct);
		await _context.SaveChangesAsync();
		return newProduct;
	}
	
	public async Task<Domain.Entities.Product> UpdateProduct(Guid productId, ProductInputDTO product)
	{
		var existingProduct = await _context.Products.FindAsync(productId);
		if (existingProduct == null)
		{
			return new Domain.Entities.Product();
		}
		
		existingProduct.Name = product.Name;
		existingProduct.Description = product.Description;
		existingProduct.Price = product.Price;
		existingProduct.CategoryId = product.CategoryId;
		existingProduct.Quantity = product.Quantity;
		existingProduct.CreatedTimeStamp = DateTime.UtcNow;

		_context.Products.Update(existingProduct);
		await _context.SaveChangesAsync();
		return existingProduct;
	}
}