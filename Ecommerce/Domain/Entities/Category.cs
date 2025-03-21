namespace Ecommerce.Domain.Entities;

public class Category
{
	public Guid CategoryId { get; set; }
	public string Name { get; set; }
	public string Type { get; set; }
	public DateTime CreatedTimeStamp {get; set;}
}