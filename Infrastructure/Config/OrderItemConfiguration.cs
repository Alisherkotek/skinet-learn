using Core.Entities.OrderAggregates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config;

public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
{
    public void Configure(EntityTypeBuilder<OrderItem> builder)
    {
        builder.OwnsOne(o => o.ItemOrdered, o => o.WithOwner());
        builder.Property(x => x.Price).HasColumnType("decimal(18, 2)");
        
    }
}