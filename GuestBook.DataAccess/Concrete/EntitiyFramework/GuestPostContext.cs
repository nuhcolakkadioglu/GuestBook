using GuestBook.DataAccess.Concrete.Mappings;
using GuestBook.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBook.DataAccess.Concrete.EntitiyFramework
{
    public class GuestPostContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=guestBook;integrated security=true");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GuestBookMap());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<GuestPost> GuestPosts { get; set; }

    }
}
