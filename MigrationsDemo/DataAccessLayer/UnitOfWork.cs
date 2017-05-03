using MigrationsDemo.Data;
using System;

namespace MigrationsDemo.DataAccessLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        private BlogContext context = new BlogContext();
        private BlogRepository blogRepository;
        private PostRepository postRepository;

        public GenericRepository<Blog> BlogRepository
        {
            get
            {
                if (blogRepository == null)
                {
                    blogRepository = new BlogRepository(context);
                }
                return blogRepository;
            }
        }

        public GenericRepository<Post> PostRepository
        {
            get
            {
                if (postRepository == null)
                {
                    postRepository = new PostRepository(context);
                }
                return postRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
