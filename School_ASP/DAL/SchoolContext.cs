using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using School_ASP.Models;

namespace School_ASP.DAL
{
    public class SchoolContext : DbContext 
    {

        public SchoolContext() : base("SchoolConnection")
        {

        }

        public DbSet<Etudiant> etudiants { get; set; }
        public DbSet<Classe> classes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}