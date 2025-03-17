using System.Text.Json.Serialization;

namespace Ecommerce.Modules.Product;

public class Product
{
	public Guid Id { get; set; }
	public string Name { get; set; }
	public string Description { get; set; }
	public string Price { get; set; }
	[JsonIgnore]
	public DateTime CreatedTimeStamp {get; set;}
}