using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace VivatInternship.Backend.Data.EntityConfigurations
{
     public class UserEntityConfiguration : IEntityTypeConfiguration<User>
     {
          public void Configure(EntityTypeBuilder<User> entity)
          {
               entity.HasKey(b => b.UserId);               
               entity.Property(b => b.Username).HasMaxLength(15).IsRequired();
          }
     }
}
