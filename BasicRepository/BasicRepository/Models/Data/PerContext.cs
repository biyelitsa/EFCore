using BasicRepository.Models.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicRepository.Models.Data
{
    public class PerContext:DbContext
    {
        public PerContext(DbContextOptions<PerContext> options):base(options)
        {
            
        }
        public DbSet<Personnel> Personnels { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}
