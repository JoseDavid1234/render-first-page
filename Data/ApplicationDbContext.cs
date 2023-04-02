using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using prueba_postgres_2.Models;

namespace prueba_postgres_2.Data
{
    public class ApplicationDbContext:DbContext
    {
      public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options){}
      public DbSet<Persona> Personas{get;set;}
    }
}