using MigrationsDemo.Data;
using System.Collections.Generic;

namespace MigrationsDemo.DataAccessLayer
{
    public class BlogRepository : GenericRepository<Blog>, IBlogRepository
    {
        public BlogRepository(BlogContext context) : base(context)
        {
        }

        public void DeleteBlog(int blogId)
        {
            Delete(blogId);
        }

        public IEnumerable<Blog> GetBlogs()
        {
            return GetAll();
        }

        public Blog GetBlogByID(int blogId)
        {
            return GetByID(blogId);
        }

        public void InsertBlog(Blog blog)
        {
            Insert(blog);
        }

        public void UpdateBlog(Blog blog)
        {
            Update(blog);
        }
    }
}
