using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Models;

namespace Domain.Entities
{
    public class NativoContext : DbContext
    {
        
        public NativoContext(DbContextOptions<NativoContext> options) : base(options) 
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            NativoSeeder.SeedDepartament(builder);
            NativoSeeder.SeedMunicipality(builder);              
            NativoSeeder.SeedNeighborhood(builder);
        }

        public virtual DbSet<Departament> Departaments { get; set; }
        public virtual DbSet<Municipality> Municipalities { get; set; }
        public virtual DbSet<Neighborhood> Neighborhoods  { get; set; }

    }
}
