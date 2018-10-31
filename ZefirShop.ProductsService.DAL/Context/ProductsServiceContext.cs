using Microsoft.EntityFrameworkCore;
using ZefirShop.ProductsService.DAL.Entities;

namespace ZefirShop.ProductsService.DAL.Context
{
    public class ProductsServiceContext : DbContext
    {
        public ProductsServiceContext(DbContextOptions<ProductsServiceContext> options)
            : base(options)
        { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
