using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Reflection.Emit;

namespace VivatInternship.Backend.Data.EntityConfigurations
{
     public class BasketTypeConfiguration : IEntityTypeConfiguration<Basket>
     {
          public void Configure(EntityTypeBuilder<Basket> entity)
          {
               entity.HasKey(b => b.UniqueBasketId);

               entity.Property(b => b.OwnerId).HasMaxLength(10);

               entity.Property(b => b.CreatedTimestamp).HasDefaultValueSql("getdate()");

               entity.Property(b => b.ModifiedTimestamp).HasDefaultValueSql("getdate()")
                   .ValueGeneratedOnAddOrUpdate()
                   .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Save);

          }
     }


}
