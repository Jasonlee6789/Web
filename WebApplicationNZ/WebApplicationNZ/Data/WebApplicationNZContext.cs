using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationNZ.Models;

namespace WebApplicationNZ.Data
{
    public class WebApplicationNZContext : DbContext
    {
        public WebApplicationNZContext (DbContextOptions<WebApplicationNZContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
