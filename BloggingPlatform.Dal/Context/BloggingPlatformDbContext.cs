using Microsoft.EntityFrameworkCore;

namespace BloggingPlatform.Dal.Context
{
    public class BloggingPlatformDbContext : DbContext
    {

        public DbSet<Post> Posts { get; set; }


        public BloggingPlatformDbContext(DbContextOptions<BloggingPlatformDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Initial Catalog=bloggingPlatform;Integrated Security = true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>(entity =>
            {
                entity.ToTable("Post");

                entity.Property(e => e.Slug)
                .IsRequired()
                .HasMaxLength(25);
            });

        }
    }
}