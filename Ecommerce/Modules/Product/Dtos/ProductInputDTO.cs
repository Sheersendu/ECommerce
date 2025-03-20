namespace Ecommerce.Modules.Product;

public class ProductInputDTO
{
	public string Name { get; set; }
	public string Description { get; set; }
	public decimal Price { get; set; }
	public Guid CategoryId { get; set; }
	public int Quantity { get; set; }
}