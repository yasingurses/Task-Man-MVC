using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-I0GI83O\\MSSQLSERVERSS;database=ExamDB;integrated security=true;");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Gorevler> Gorevlers { get; set; }
        public DbSet<Yorum> Yorums { get; set; }
    }
}
