using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webshop.Models;

namespace webshop.Data
{
    public class webshopContext : DbContext
    {
        public webshopContext (DbContextOptions<webshopContext> options)
            : base(options)
        {
        }

        public DbSet<webshop.Models.Movie> Movie { get; set; }
    }
}
