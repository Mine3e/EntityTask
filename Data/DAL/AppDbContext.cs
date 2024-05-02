using Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL
{
    public class AppDbContext:DbContext
    {
        public DbSet<Student>Students { get; set; }
        public DbSet<Group> Groups { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MINE\\SQLEXPRESS;Database=EntityTask;Trusted_Connection=true;Integrated Security=true;Encrypt=false;TrustServerCertificate=true;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
