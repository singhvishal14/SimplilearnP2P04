using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimpilearnP4.Models;

namespace SimpilearnP4.Data
{
    public class SimpilearnDbContext : DbContext
    {
        public SimpilearnDbContext (DbContextOptions<SimpilearnDbContext> options)
            : base(options)
        {
        }

        public DbSet<SimpilearnP4.Models.RainBowSchool> RainBowSchool { get; set; } = default!;
    }
}
