using Ecommerce.Modules.Product;

namespace Ecommerce.Domain.Entities;

public class Category : BaseDTO
{
	public Guid CategoryId { get; set; }
	public string Name { get; set; }
	public string Type { get; set; }
}