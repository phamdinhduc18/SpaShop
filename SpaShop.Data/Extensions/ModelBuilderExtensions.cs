using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SpaShop.Data.Entities;
using SpaShop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaShop.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
               new AppConfig() { Key = "HomeTitle", Value = "Đây là trang chủ Spa Shop" },
               new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of Spa Shop" },
               new AppConfig() { Key = "HomeDescription", Value = "This is description of Spa Shop" }
               );
            modelBuilder.Entity<Language>().HasData(
                new Language() { LanguageId = "vi-VN", Name = "Tiếng Việt", IsDefault = true },
                new Language() { LanguageId = "en-US", Name = "English", IsDefault = false });

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active,
                },
                 new Category()
                 {
                     Id = 2,
                     IsShowOnHome = true,
                     ParentId = null,
                     SortOrder = 2,
                     Status = Status.Active
                 });

            modelBuilder.Entity<CategoryTranslation>().HasData(
                  new CategoryTranslation() { Id = 1, CategoryId = 1, Name = "Dưỡng da", LanguageId = "vi-VN", SeoAlias = "duong-da", SeoDescription = "Sản phẩm dưỡng da", SeoTitle = "Sản phẩm dưỡng da" },
                  new CategoryTranslation() { Id = 2, CategoryId = 1, Name = "Lotion", LanguageId = "en-US", SeoAlias = "Lotion", SeoDescription = "Skin care products", SeoTitle = "Skin care products for women" },
                  new CategoryTranslation() { Id = 3, CategoryId = 2, Name = "Trị mụn", LanguageId = "vi-VN", SeoAlias = "tri-mun", SeoDescription = "Sản phẩm trị mụn", SeoTitle = "SSản phẩm trị mụn" },
                  new CategoryTranslation() { Id = 4, CategoryId = 2, Name = "Acne treatment", LanguageId = "en-US", SeoAlias = "acne-treatment", SeoDescription = "Acne products", SeoTitle = "Acne products" }
                    );

            modelBuilder.Entity<Product>().HasData(
           new Product()
           {
               Id = 1,
               DateCreated = DateTime.Now,
               OriginalPrice = 100000,
               Price = 200000,
               Stock = 0,
               ViewCount = 0,
           });
            modelBuilder.Entity<ProductTranslation>().HasData(
                 new ProductTranslation()
                 {
                     Id = 1,
                     ProductId = 1,
                     Name = "Dưỡng body Lotion Mask Muji",
                     LanguageId = "vi-VN",
                     SeoAlias = "duong-body-lotion-mask-muji",
                     SeoDescription = "Dưỡng body Lotion Mask Muji",
                     SeoTitle = "Dưỡng body Lotion Mask Muji",
                     Details = "Dưỡng body Lotion Mask Muji",
                     Description = "Dưỡng body Lotion Mask Muji"
                 },
                    new ProductTranslation()
                    {
                        Id = 2,
                        ProductId = 1,
                        Name = "Body Lotion Mask Muji",
                        LanguageId = "en-US",
                        SeoAlias = "body-lotion-mask-muji",
                        SeoDescription = "Body Lotion Mask Muji",
                        SeoTitle = "Body Lotion Mask Muji",
                        Details = "Body Lotion Mask Muji",
                        Description = "Body Lotion Mask Muji"
                    });
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 }
                );
            // any guid
            var roleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "admin@gmail.com",
                NormalizedEmail = "admin@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Admin@123"),
                SecurityStamp = string.Empty,
                FirstName = "Duc",
                LastName = "Pham",
                Dob = new DateTime(2021, 05, 01)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });
        }

    }
}
