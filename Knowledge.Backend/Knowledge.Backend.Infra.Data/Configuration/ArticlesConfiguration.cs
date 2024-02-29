using Knowledge.Backend.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Knowledge.Backend.Infra.Data.Configuration
{
    internal class ArticlesConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                   .HasMaxLength(150)
                   .HasColumnName("Name")
                   .IsRequired();

            builder.Property(x => x.Description)
                   .HasMaxLength(200)
                   .HasColumnName("Description")
                   .IsRequired();

            builder.Property(x => x.ImageUrl)
                   .HasMaxLength(800)
                   .HasColumnName("Image")
                   .IsRequired();

            builder.Property(x => x.Content)
                   .HasMaxLength(5000)
                   .HasColumnName("Content")
                   .IsRequired();

            builder.HasOne(x => x.User)
                   .WithMany(x => x.Articles)
                   .HasForeignKey(x => x.UserId)
                   .OnDelete(DeleteBehavior.ClientCascade);

            builder.HasOne(x => x.Category)
                   .WithMany(x => x.Articles)
                   .HasForeignKey(x => x.CategoryId)
                   .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}
