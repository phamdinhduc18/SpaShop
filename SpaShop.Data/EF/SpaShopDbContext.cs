using Microsoft.EntityFrameworkCore;
using SpaShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaShop.Data.EF
{
    public class SpaShopDbContext : DbContext
    {
        public SpaShopDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products;
        public DbSet<Category> Categories;
    }
}
