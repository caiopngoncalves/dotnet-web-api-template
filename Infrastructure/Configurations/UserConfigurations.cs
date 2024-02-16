using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;
public class UserConfigurations : IEntityTypeConfiguration<User>
{
   public void Configure(EntityTypeBuilder<User> builder)
   {
      builder
         .ToTable("Users")
         .HasKey(u => u.Id);
   }
}