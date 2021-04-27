using BloggingPlatform.Dal.Database;
using Microsoft.EntityFrameworkCore;

namespace BloggingPlatform.Dal.Database
{
    public partial class BloggingPlatformDbContext : DbContext
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
                .HasMaxLength(100);

                entity.Property(e => e.Title)
               .IsRequired()
               .HasMaxLength(50);

                entity.Property(e => e.Description)
               .IsRequired()
               .HasMaxLength(250);

                entity.Property(e => e.Body)
               .IsRequired()
               .HasMaxLength(250);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}