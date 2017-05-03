using System.ComponentModel.DataAnnotations;

namespace MigrationsDemo.Data
{
    public class Post
    {
        public int PostId { get; set; }
        [MaxLength(200)]
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
        public string Abstract { get; set; }
    }
}
