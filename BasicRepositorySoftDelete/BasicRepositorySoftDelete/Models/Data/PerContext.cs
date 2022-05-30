using BasicRepositorySoftDelete.Models.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicRepositorySoftDelete.Models.Data
{
    public class PerContext:DbContext
    {
        public PerContext(DbContextOptions<PerContext> op):base(op)
        {

        }
        public DbSet<Personnel> Personnels { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}
