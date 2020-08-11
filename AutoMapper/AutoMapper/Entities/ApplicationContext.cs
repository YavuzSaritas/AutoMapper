using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapper.Entities
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions option):base(option)
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<Adress> Adress { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
