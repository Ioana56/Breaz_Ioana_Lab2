using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Breaz_Ioana_Lab2.Models;

namespace Breaz_Ioana_Lab2.Data
{
    public class Breaz_Ioana_Lab2Context : DbContext
    {
        public Breaz_Ioana_Lab2Context (DbContextOptions<Breaz_Ioana_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Breaz_Ioana_Lab2.Models.Book> Book { get; set; } = default!;
    }
}
