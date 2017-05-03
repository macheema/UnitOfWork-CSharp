using MigrationsDemo.Data;
using System.Collections.Generic;

namespace MigrationsDemo.DataAccessLayer
{
    public class PostRepository : GenericRepository<Post>, IPostRepository
    {
        public PostRepository(BlogContext context) : base(context)
        {
        }

        public void DeletePost(int postId)
        {
            Delete(postId);
        }

        public IEnumerable<Post> GetPosts()
        {
            return GetAll();
        }

        public Post GetPostByID(int postId)
        {
            return GetByID(postId);
        }

        public void InsertPost(Post post)
        {
            Insert(post);
        }

        public void UpdatePost(Post post)
        {
            Update(post);
        }
    }
}
