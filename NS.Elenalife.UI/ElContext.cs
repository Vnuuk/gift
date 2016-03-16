using System.Data.Entity;

namespace NS.Elenalife.UI
{
    public class ElContext : DbContext
    {
        public ElContext() : base("DefaultConnection") { }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>()
                        .HasMany(s => s.Images)
                        .WithRequired(s => s.Post)
                        .HasForeignKey(s => s.PostId);

        }
    }
}