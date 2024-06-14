using Core.Entities;
using Core.Entities.Identity;
using Core.Entities.OrderAggregate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Reflection;
using System.Text.Json;

namespace Infrastructure.Data
{
	public class ApplicationDBContext : IdentityDbContext<AppUser>
	{
		public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
		{

		}

		public DbSet<Product> Products { get; set; }
		public DbSet<ProductBrand> ProductBrands { get; set; }
		public DbSet<ProductType> ProductTypes { get; set; }

		public DbSet<Order> Orders { get; set; }
		public DbSet<OrderItem> OrderItems { get; set; }
		public DbSet<DeliveryMethod> DeliveryMethods { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{

			base.OnModelCreating(modelBuilder);			

			try
			{
				var context = modelBuilder;

				var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
				Console.WriteLine(path);
				
				var brandsData = File.ReadAllText(path + @"/Data/SeedData/brands.json");

				var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandsData);

				context.Entity<ProductBrand>().HasData(brands);

				var typesData = File.ReadAllText(path + @"/Data/SeedData/types.json");

				var types = JsonSerializer.Deserialize<List<ProductType>>(typesData);
				context.Entity<ProductType>().HasData(types);

				var productsData = File.ReadAllText(path + @"/Data/SeedData/products.json");

				var products = JsonSerializer.Deserialize<List<Product>>(productsData);

				context.Entity<Product>().HasData(products);

				var deliveryData = File.ReadAllText(path + @"/Data/SeedData/delivery.json");

				var deliveryMethods = JsonSerializer.Deserialize<List<DeliveryMethod>>(deliveryData);

				context.Entity<DeliveryMethod>().HasData(deliveryMethods);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}


	}
}