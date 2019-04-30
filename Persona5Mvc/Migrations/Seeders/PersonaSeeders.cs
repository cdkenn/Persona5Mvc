using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using Persona5Mvc.Models;

namespace Persona5Mvc.Migrations.Seeders
{
    public class PersonaSeeders : ISeeder
    {
        public void SeedData(Persona5DbContext context)
        {
            GenerateFoolPersonas(context);
            GenerateChariotPersonas(context);
        }

        private void GenerateFoolPersonas(Persona5DbContext context)
        {
            List<Persona> personas = new List<Persona>
            {
                new Persona
                {
                    Name = "Arsene",
                    Level = 1,
                    Arcana = "Fool",
                    BaseStrength = 2,
                    BaseMagic = 2,
                    BaseEndurance = 2,
                    BaseAgility = 3,
                    BaseLuck = 1
                },
                new Persona
                {
                    Name = "Obariyon",
                    Level = 8,
                    Arcana = "Fool",
                    BaseStrength = 7,
                    BaseMagic = 3,
                    BaseEndurance = 9,
                    BaseAgility = 8,
                    BaseLuck = 4
                },
            };

            foreach (var p in personas)
            {
                context.Personas.AddOrUpdate(i => i.Name, p);
            }
        }

        private void GenerateChariotPersonas(Persona5DbContext context)
        {
            List<Persona> personas = new List<Persona>
            {
                new Persona
                {
                    Name = "Agathion",
                    Level = 3,
                    Arcana = "Chariot",
                    BaseStrength = 3,
                    BaseMagic = 4,
                    BaseEndurance = 5,
                    BaseAgility = 7,
                    BaseLuck = 3
                },
                new Persona
                {
                    Name = "Slime",
                    Level = 10,
                    Arcana = "Chariot",
                    BaseStrength = 9,
                    BaseMagic = 6,
                    BaseEndurance = 11,
                    BaseAgility = 6,
                    BaseLuck = 5
                },
            };

            foreach (var p in personas)
            {
                context.Personas.AddOrUpdate(i => i.Name, p);
            }
        }
    }
}