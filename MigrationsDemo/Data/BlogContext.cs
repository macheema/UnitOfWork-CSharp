using System.Data.Entity;

namespace MigrationsDemo.Data
{
    public class BlogContext : DbContext
    {
        public BlogContext() : base("BlogContext")
        {
        }
        public DbSet<Blog> Blogs { get; set; }
    }
}
