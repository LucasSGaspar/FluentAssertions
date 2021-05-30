using Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class TagConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.ToTable("Tag");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Nome).HasColumnType("VARCHAR(20)").IsRequired();
            builder.Property(t => t.Observacao).HasColumnType("VARCHAR(100)");
        }
    }
}
