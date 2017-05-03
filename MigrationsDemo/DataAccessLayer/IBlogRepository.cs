using MigrationsDemo.Data;
using System.Collections.Generic;

namespace MigrationsDemo.DataAccessLayer
{
    interface IBlogRepository : IRespository<Blog>
    {
        IEnumerable<Blog> GetBlogs();
        Blog GetBlogByID(int blogId);
        void InsertBlog(Blog blog);
        void DeleteBlog(int blogId);
        void UpdateBlog(Blog blog);
    }
}
