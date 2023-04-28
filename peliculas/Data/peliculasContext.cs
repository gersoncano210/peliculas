using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using peliculas.Models;

namespace peliculas.Data
{
    public class peliculasContext : DbContext
    {
        public peliculasContext (DbContextOptions<peliculasContext> options)
            : base(options)
        {
        }

        public DbSet<peliculas.Models.movie> movie { get; set; } = default!;
    }
}
