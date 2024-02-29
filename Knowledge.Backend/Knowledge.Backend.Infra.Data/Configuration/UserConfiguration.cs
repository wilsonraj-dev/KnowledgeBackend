using Knowledge.Backend.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Knowledge.Backend.Infra.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                   .HasMaxLength(100)
                   .HasColumnName("Name")
                   .IsRequired();

            builder.Property(x => x.Email)
                   .HasMaxLength(100)
                   .HasColumnName("Email")
                   .IsRequired();

            builder.Property(x => x.Password)
                   .HasMaxLength(50)
                   .HasColumnName("Password")
                   .IsRequired();

            builder.Property(x => x.CreateTime)
                   .HasColumnName("CreateTime")
                   .IsRequired();

            builder.Property(x => x.UpdateTime)
                   .HasColumnName("UpdateTime")
                   .IsRequired();
        }
    }
}
