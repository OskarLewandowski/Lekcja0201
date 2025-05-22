using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lekcja0201.Models;

namespace Lekcja0201.Data
{
    public class Lekcja0201Context : DbContext
    {
        public Lekcja0201Context (DbContextOptions<Lekcja0201Context> options)
            : base(options)
        {
        }

        public DbSet<Lekcja0201.Models.Pattern1> Pattern1 { get; set; } = default!;
    }
}
