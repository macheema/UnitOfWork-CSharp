using MigrationsDemo.Migrations;
using System;
using System.Data.Entity;
using MigrationsDemo.Data;
using MigrationsDemo.DataAccessLayer;

namespace MigrationsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BlogContext, Configuration>());
            UnitOfWork uWork = new UnitOfWork();
            uWork.BlogRepository.AddOrUpdate(new Blog { Name = "Another Blog" });
            uWork.Save();
            foreach (var blog in uWork.BlogRepository.GetAll())
            {
                Console.WriteLine(blog.Name);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
