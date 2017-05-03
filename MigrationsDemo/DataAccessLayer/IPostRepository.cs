using MigrationsDemo.Data;
using System.Collections.Generic;

namespace MigrationsDemo.DataAccessLayer
{
    interface IPostRepository : IRespository<Post>
    {
        IEnumerable<Post> GetPosts();
        Post GetPostByID(int postId);
        void InsertPost(Post post);
        void DeletePost(int postId);
        void UpdatePost(Post post);
    }
}
