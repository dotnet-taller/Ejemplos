using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Ejemplo11.Models
{
    public class contexto : DbContext
    {

        public DbSet<Materia> Materias { get; set; }


        static contexto()
        {
            //Database.SetInitializer<contexto>(new EntitiesContextInitializer());
            //Database.SetInitializer<contexto>(new DropCreateDatabaseIfModelChanges<contexto>());
            //Database.SetInitializer<contexto>(new CreateDatabaseIfNotExists<contexto>());
            Database.SetInitializer<contexto>(null);

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }
    }
}