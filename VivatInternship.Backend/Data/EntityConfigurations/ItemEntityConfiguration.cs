using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using Microsoft.Identity.Client;

namespace VivatInternship.Backend.Data.EntityConfigurations
{
     public class ItemTypeConfiguration : IEntityTypeConfiguration<Item>
     {
          public void Configure(EntityTypeBuilder<Item> entity)
          {
               entity.HasKey(b => b.ItemId);
               entity.Property(b => b.Name).IsRequired().HasMaxLength(50);
               entity.Property(b => b.Price).IsRequired();
               
          }
     }


}
