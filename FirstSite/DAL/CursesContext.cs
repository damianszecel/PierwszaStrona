using FirstSite.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace FirstSite.DAL
{
    public class CursesContext : DbContext
    {
        public CursesContext() : base("CursesContext")
        {

        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Kategoria> Kategories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderPosition> OrderPositions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //tworzenie liczby mnogiej podczas tworzenia i pod spodem wylaczenie tego 

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        
    }
}