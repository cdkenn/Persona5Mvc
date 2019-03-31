namespace Persona5Mvc.Migrations
{
    using Persona5Mvc.Migrations.Seeders;
    using Persona5Mvc.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Persona5Mvc.Models.ConfidantDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Persona5Mvc.Models.ConfidantDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            ConfidantSeeder confSeeder = new ConfidantSeeder();
            confSeeder.Seed(context);
        }
    }
}
