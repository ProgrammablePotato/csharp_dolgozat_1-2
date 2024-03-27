using ClassLibrary1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Data
{
    public class MyContext : DbContext
    {
        public MyContext() { }
        public DbSet<CSVclass> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connMySQL = "Server=127.0.0.1;User ID=root;Password=;Database=PeopleDatabase;";

            optionsBuilder.UseMySql(connMySQL, ServerVersion.AutoDetect(connMySQL));
        }
    }
}
