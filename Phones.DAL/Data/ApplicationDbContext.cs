using Phone.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Phone.DataAcess.Data
{
	public class ApplicationDbContext : IdentityDbContext<IdentityUser>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}

		public DbSet<Category> Categories { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Company> Companies { get; set; }
		public DbSet<ShoppingCart> ShoppingCarts { get; set; }
		public DbSet<ProductImage> ProductImages { get; set; }
		public DbSet<ApplicationUser> ApplicationUsers { get; set; }
		public DbSet<OrderHeader> OrderHeaders { get; set; }
		public DbSet<OrderDetail> OrderDetails { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{

			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Category>().HasData(
				new Category { Id = 1, Name = "Smartphones", DisplayOrder = 1 },
				new Category { Id = 2, Name = "Feature Phones", DisplayOrder = 2 },
				new Category { Id = 3, Name = "Accessories", DisplayOrder = 3 }
				);

			modelBuilder.Entity<Company>().HasData(
				new Company
				{
					Id = 1,
					Name = "Tech Solution",
					StreetAddress = "123 Tech St",
					City = "Tech City",
					PostalCode = "12121",
					State = "IL",
					PhoneNumber = "6669990000"
				},
				new Company
				{
					Id = 2,
					Name = "Vivid Phones",
					StreetAddress = "999 Vid St",
					City = "Vid City",
					PostalCode = "66666",
					State = "IL",
					PhoneNumber = "7779990000"
				},
				new Company
				{
					Id = 3,
					Name = "Readers Club",
					StreetAddress = "999 Main St",
					City = "Lala land",
					PostalCode = "99999",
					State = "NY",
					PhoneNumber = "1113335555"
				}
				);


			modelBuilder.Entity<Product>().HasData(
				new Product
				{
					Id = 1,
					Title = "iPhone 13",
					Company = "Apple",
					Description = "The latest iPhone with A15 Bionic chip, 5G capability, and improved camera system.",
					ListPrice = 999,
					Price = 950,
					Price50 = 900,
					Price100 = 850,
					CategoryId = 1
				},
				new Product
				{
					Id = 2,
					Title = "Samsung Galaxy S21",
					Company = "Samsung",
					Description = "High-end smartphone with Exynos 2100, 5G, and a versatile camera setup.",
					ListPrice = 799,
					Price = 750,
					Price50 = 700,
					Price100 = 650,
					CategoryId = 1
				},
				new Product
				{
					Id = 3,
					Title = "Google Pixel 6",
					Company = "Google",
					Description = "Google's flagship phone with Tensor chip, excellent camera, and pure Android experience.",
					ListPrice = 599,
					Price = 550,
					Price50 = 500,
					Price100 = 450,
					CategoryId = 1
				},
				new Product
				{
					Id = 4,
					Title = "Nokia 3310",
					Company = "Nokia",
					Description = "Classic feature phone with long battery life and durable build.",
					ListPrice = 50,
					Price = 45,
					Price50 = 40,
					Price100 = 35,
					CategoryId = 2
				},
				new Product
				{
					Id = 5,
					Title = "Samsung earpuds",
					Company = "Samsung",
					Description = "Affordable feature phone with basic functionalities and long battery life.",
					ListPrice = 30,
					Price = 27,
					Price50 = 25,
					Price100 = 20,
					CategoryId = 2
				},
				new Product
				{
					Id = 6,
					Title = "Apple AirPods",
					Company = "Apple",
					Description = "Wireless earbuds with high-quality sound and seamless integration with Apple devices.",
					ListPrice = 199,
					Price = 180,
					Price50 = 170,
					Price100 = 160,
					CategoryId = 3
				},
				new Product
				{
					Id = 7,
					Title = "OnePlus 9 Pro",
					Company = "OnePlus",
					Description = "Flagship phone with Snapdragon 888, Hasselblad camera, and 120Hz AMOLED display.",
					ListPrice = 899,
					Price = 850,
					Price50 = 800,
					Price100 = 750,
					CategoryId = 1
				},
			new Product
			{
				Id = 8,
				Title = "Xiaomi Mi 11",
				Company = "Xiaomi",
				Description = "High-performance phone with Snapdragon 888, 108MP camera, and 55W fast charging.",
				ListPrice = 749,
				Price = 700,
				Price50 = 650,
				Price100 = 600,
				CategoryId = 1
			},
			new Product
			{
				Id = 9,
				Title = "Sony Xperia 1 III",
				Company = "Sony",
				Description = "Premium phone with 4K OLED display, Snapdragon 888, and advanced camera features.",
				ListPrice = 1299,
				Price = 1250,
				Price50 = 1200,
				Price100 = 1150,
				CategoryId = 1
			},
			new Product
			{
				Id = 10,
				Title = "Motorola Edge 20",
				Company = "Motorola",
				Description = "Mid-range phone with Snapdragon 778G, 144Hz display, and 108MP camera.",
				ListPrice = 499,
				Price = 450,
				Price50 = 400,
				Price100 = 350,
				CategoryId = 1
			},
			new Product
			{
				Id = 11,
				Title = "Asus ROG Phone 5",
				Company = "Asus",
				Description = "Gaming phone with Snapdragon 888, 144Hz AMOLED display, and massive 6000mAh battery.",
				ListPrice = 999,
				Price = 950,
				Price50 = 900,
				Price100 = 850,
				CategoryId = 1
			},
			new Product
			{
				Id = 12,
				Title = "LG Velvet",
				Company = "LG",
				Description = "Stylish phone with Snapdragon 845, dual-screen compatibility, and 48MP camera.",
				ListPrice = 599,
				Price = 550,
				Price50 = 500,
				Price100 = 450,
				CategoryId = 1
			}
				);
		}
	}
}