using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AplicacionSQLITE.Models;

namespace AplicacionSQLITE.Data
{
    public class AplicacionSQLITEContext : DbContext
    {
        public AplicacionSQLITEContext (DbContextOptions<AplicacionSQLITEContext> options)
            : base(options)
        {
        }

        public DbSet<AplicacionSQLITE.Models.Persona> Persona { get; set; } = default!;
    }
}
