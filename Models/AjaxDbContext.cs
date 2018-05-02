using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AjaxDemo.Models
{
    public class AjaxDbContext : DbContext
    {
        public AjaxDbContext()
        {
        }

        public DbSet<Destination> Destinations { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(@"Server=localhost;Port=8889;database=AjaxDemo;uid=root;pwd=root;");
        }

        public AjaxDbContext(DbContextOptions<AjaxDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}