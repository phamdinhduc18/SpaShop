using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SpaShop.Data.Entities;
using System;

namespace SpaShop.Data.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.OrderDate).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.Id).UseIdentityColumn();
        }
    }
}
