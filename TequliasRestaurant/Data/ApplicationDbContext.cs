using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TequliasRestaurant.Models;

namespace TequliasRestaurant.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<ProductIngredients> ProductIngredients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductIngredients>()
                .HasKey(pi => new { pi.ProductId, pi.IngredientId });

            modelBuilder.Entity<ProductIngredients>()
                .HasOne(pi => pi.Product)
                .WithMany(i => i.ProductIngredients)
                .HasForeignKey(pi => pi.ProductId);

            modelBuilder.Entity<ProductIngredients>()
                .HasOne(pi => pi.Ingredient)
                .WithMany(i => i.ProductIngredients)
                .HasForeignKey(pi => pi.IngredientId);

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Appetizer" },
                new Category { CategoryId = 2, Name = "Entree" },
                new Category { CategoryId = 3, Name = "Side Dish" },
                new Category { CategoryId = 4, Name = "Dessert" },
                new Category { CategoryId = 5, Name = "Beverage" }
                );

            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient { IngredientId = 1, Name = "Beef" },
                 new Ingredient { IngredientId = 2, Name = "Chicken" },
                  new Ingredient { IngredientId = 3, Name = "Fish" },
                   new Ingredient { IngredientId = 4, Name = "Tortilla" },
                    new Ingredient { IngredientId = 5, Name = "Lettuce" },
                     new Ingredient { IngredientId = 6, Name = "Tomato" }
                     );

            modelBuilder.Entity<Product>().HasData(

                new Product
                {
                    ProductId = 1,
                    Name = "Beef Taco",
                    Discription = "A delicious Beef Taco",
                    Price = 2.50m,
                    Stock = 100,
                    CategoryId = 2
                },
                 new Product
                 {
                     ProductId = 2,
                     Name = "Chicken Taco",
                     Discription = "A delicious Chicken Taco",
                     Price = 1.99m,
                     Stock = 101,
                     CategoryId = 2
                 },
                  new Product
                  {
                      ProductId = 3,
                      Name = "Fish Taco",
                      Discription = "A delicious Fish Taco",
                      Price = 3.99m,
                      Stock = 90,
                      CategoryId = 2
                  }
                );

            modelBuilder.Entity<ProductIngredients>().HasData(
                new ProductIngredients { ProductId = 1, IngredientId = 1 },
                new ProductIngredients { ProductId = 1, IngredientId = 4 },
                new ProductIngredients { ProductId = 1, IngredientId = 5 },
                new ProductIngredients { ProductId = 1, IngredientId = 6 },
                 new ProductIngredients { ProductId = 2, IngredientId = 2 },
                new ProductIngredients { ProductId = 2, IngredientId = 4 },
                new ProductIngredients { ProductId = 2, IngredientId = 5 },
                new ProductIngredients { ProductId = 2, IngredientId = 6 },
                  new ProductIngredients { ProductId = 3, IngredientId = 3 },
                new ProductIngredients { ProductId = 3, IngredientId = 4 },
                new ProductIngredients { ProductId = 3, IngredientId = 5 },
                new ProductIngredients { ProductId = 3, IngredientId = 6 }
           );
                    


        }



    }
}