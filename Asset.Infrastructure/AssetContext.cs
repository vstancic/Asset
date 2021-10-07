using Microsoft.EntityFrameworkCore;

namespace Asset.Infrastructure
{
    public class AssetContext : DbContext
    {
 
        public AssetContext(DbContextOptions<AssetContext> options)
            : base(options)
        {
 
        }
 
        public DbSet<Asset> Asset { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Asset>()
                .Property(b => b.Location)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}