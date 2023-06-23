using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApp2.Models;

namespace WebApp2.Data
{
    public class WebApp2Context : DbContext
    {
        public WebApp2Context (DbContextOptions<WebApp2Context> options)
            : base(options)
        {
        }

        public DbSet<WebApp2.Models.Department> Department { get; set; } = default!;

        public DbSet<WebApp2.Models.Employee>? Employee { get; set; }
    }
}
