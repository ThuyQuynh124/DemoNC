using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemoNC.Models;

    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext (DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<DemoNC.Models.Employee> Employee { get; set; }

        public DbSet<DemoNC.Models.Person> Person { get; set; }

        public DbSet<DemoNC.Models.Product> Product { get; set; }

        public DbSet<DemoNC.Models.Student> Student { get; set; }

        public DbSet<DemoNC.Models.Movie> Movie { get; set; }
    }
