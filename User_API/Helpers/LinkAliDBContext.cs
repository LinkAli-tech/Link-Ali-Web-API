using Microsoft.EntityFrameworkCore;
using User_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace User_API.Helpers
{
    public class LinkAliDBContext : DbContext
    {
        public LinkAliDBContext(DbContextOptions<LinkAliDBContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Quote> Quotes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=LinkAliDB;Integrated Security=True");
        }
    }
}
