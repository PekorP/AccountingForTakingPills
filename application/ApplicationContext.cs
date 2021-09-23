using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AccountingForTakingPills
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Drug> Drugs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ListOfDrugs> ListsOfDrugs { get; set; }
        public DbSet<ListOfUseDrugs> ListsOfUseDrugs { get; set; }

        public ApplicationContext()
        {
            Database.OpenConnection();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-DFKCC5S\\SQLEXPRESS;Database=DB_AFTP;Trusted_Connection=True;");
        }
    }
}
