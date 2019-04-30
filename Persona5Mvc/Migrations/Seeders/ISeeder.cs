using Persona5Mvc.Models;

namespace Persona5Mvc.Migrations.Seeders
{
    interface ISeeder
    {
        void SeedData(Persona5DbContext context);
    }
}
