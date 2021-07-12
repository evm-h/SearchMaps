using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SearchMaps.Models.Domain;

namespace SearchMaps.Models
{
    public class DataBase
    {
        public class DBContext : DbContext
        {
            public DbSet<MainTable> maintable { get; set; }
            public DbSet<Region> regions { get; set; }

            public DBContext()
            {
                Database.EnsureCreated();
            }        
            static readonly string connection = "server=localhost;user=root;database=okved;password=root;";

            readonly ServerVersion version = ServerVersion.AutoDetect(connection);

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseMySql(connection, version);

            }
        }

    }
}
