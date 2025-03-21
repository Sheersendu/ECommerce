using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Modules.Product;

[ApiController]
[Route("products")]
public class ProductController : ControllerBase
{
	private readonly IProductService _productService;
	public ProductController(IProductService productService)
	{
		_productService = productService;
	}
	
	[HttpGet("{productId}")]
	public async Task<Domain.Entities.Product> GetProduct([FromRoute]Guid productId)
	{
		return await _productService.GetProduct(productId);
	}

	[HttpPost]
	public async Task<Domain.Entities.Product> AddProduct(ProductInputDTO product)
	{
		return await _productService.AddProduct(product);
	}
	
	[HttpPost("update/{productId}")]
	public async Task<Domain.Entities.Product> UpdateProduct([FromRoute]Guid productId, ProductInputDTO product)
	{
		return await _productService.UpdateProduct(productId, product);
	}
}