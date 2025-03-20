using Ecommerce.Modules.Product;

namespace Ecommerce.Domain.Entities;

public class Product : BaseDTO
{
	public string Name { get; set; }
	public string Description { get; set; }
	public decimal Price { get; set; }
	public Guid CategoryId { get; set; } // Foreign key property
	public Category Category { get; set; } // Navigation property
	public int Quantity { get; set; }
}