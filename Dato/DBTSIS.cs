using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using MySql.Data.Entity;
using Entidad;
namespace Dato
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class DBTSIS : IdentityDbContext<User>
    {
        public DBTSIS()
            : base("TSIS")
        {

        }

        public DbSet<Pais> Paiss { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Municipio> Municipios { get; set; }
        public DbSet<Persona> Personas { get; set; }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //}
    }
}
