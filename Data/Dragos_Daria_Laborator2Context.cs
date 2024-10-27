using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dragos_Daria_Laborator2.Models;

namespace Dragos_Daria_Laborator2.Data
{
    public class Dragos_Daria_Laborator2Context : DbContext
    {
        public Dragos_Daria_Laborator2Context (DbContextOptions<Dragos_Daria_Laborator2Context> options)
            : base(options)
        {
        }

        public DbSet<Dragos_Daria_Laborator2.Models.Book> Book { get; set; } = default!;
        public DbSet<Dragos_Daria_Laborator2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Dragos_Daria_Laborator2.Models.Category> Category { get; set; } = default!;
    }
}
