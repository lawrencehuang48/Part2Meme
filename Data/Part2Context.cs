using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Part2.Models
{
    public class Part2Context : DbContext
    {
        public Part2Context (DbContextOptions<Part2Context> options)
            : base(options)
        {
        }

        public DbSet<Part2.Models.MemeItem> MemeItem { get; set; }
    }
}
