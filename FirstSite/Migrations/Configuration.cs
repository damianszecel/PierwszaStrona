namespace FirstSite.Migrations
{
    using FirstSite.DAL;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FirstSite.DAL.CursesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "FirstSite.DAL.CursesContext";
        }

        protected override void Seed(FirstSite.DAL.CursesContext context)
        {
            CursesInitializer.SeedCursesData(context);

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
