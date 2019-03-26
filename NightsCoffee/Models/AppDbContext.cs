using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NightsCoffee.Models
{
    public class AppDbContext: DbContext
    {
        //requires instance of DbContext options or wont work, use constructor arguement below
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }

        public DbSet<Coffee> Coffees { get; set; }

    }
}
