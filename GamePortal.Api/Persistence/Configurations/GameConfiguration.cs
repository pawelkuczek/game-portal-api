using GamePortal.Api.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GamePortal.Api.Persistence.Configurations;

public class GameConfiguration : IEntityTypeConfiguration<Game>
{
    public void Configure(EntityTypeBuilder<Game> builder)
    {
        builder.ToTable("Games");

        builder.HasKey(g => g.Id);

        builder.Property(g => g.Title)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(g => g.Description)
            .HasMaxLength(2000);

        builder.Property(g => g.ReleaseDate);

        builder
            .HasMany(g => g.Genres)
            .WithMany(ge => ge.Games);

        builder
            .HasMany(g => g.Platforms)
            .WithMany(p => p.Games);
    }
}