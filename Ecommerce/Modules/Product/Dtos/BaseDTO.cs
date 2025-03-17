using System.Text.Json.Serialization;

namespace Ecommerce.Modules.Product;

public class BaseDTO
{
	public Guid Id { get; set; }
	[JsonIgnore]
	public DateTime CreatedTimeStamp {get; set;}
}