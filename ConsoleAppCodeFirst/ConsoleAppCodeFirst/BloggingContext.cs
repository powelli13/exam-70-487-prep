using Microsoft.EntityFrameworkCore;

namespace ConsoleAppCodeFirst
{
    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=localhost;Database=Blogging;Trusted_Connection=True;");
    }
}
