using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationNZ.Models
{
    public class WebApplicationNZContext : DbContext
    {
        public WebApplicationNZContext (DbContextOptions<WebApplicationNZContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationNZ.Models.Movie> Movie { get; set; }
    }
}
