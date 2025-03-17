using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Modules.Product;

[ApiController]
[Route("products")]
public class ProductController
{
	private readonly IProductService _productService;
	public ProductController(IProductService productService)
	{
		_productService = productService;
	}
	
	[HttpGet("{productId}")]
	public async Task<Product> GetProduct([FromRoute]Guid productId)
	{
		return await _productService.GetProduct(productId);
	}

	[HttpPost]
	public async Task<Product> AddProduct(ProductInputDTO product)
	{
		return await _productService.AddProduct(product);
	}
}