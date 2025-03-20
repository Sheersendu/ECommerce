using Ecommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Infrastructure;

public class AppDbContext : DbContext
{
	private readonly IConfiguration _configuration;
	public AppDbContext(IConfiguration configuration)
	{
		_configuration = configuration;
	}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseNpgsql(_configuration.GetConnectionString("DefaultConnection"));
	}
	
	public DbSet<Product> Products { get; set; }
	public DbSet<Category> Categories { get; set; }

	override protected void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Product>()
			.HasOne(p => p.Category)
			.WithMany()
			.HasForeignKey(p => p.CategoryId);
	}
}