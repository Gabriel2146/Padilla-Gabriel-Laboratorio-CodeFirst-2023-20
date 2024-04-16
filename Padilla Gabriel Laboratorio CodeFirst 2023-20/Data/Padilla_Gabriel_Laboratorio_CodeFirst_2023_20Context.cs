using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Padilla_Gabriel_Laboratorio_CodeFirst_2023_20.Models;

namespace Padilla_Gabriel_Laboratorio_CodeFirst_2023_20.Data
{
    public class Padilla_Gabriel_Laboratorio_CodeFirst_2023_20Context : DbContext
    {
        public Padilla_Gabriel_Laboratorio_CodeFirst_2023_20Context (DbContextOptions<Padilla_Gabriel_Laboratorio_CodeFirst_2023_20Context> options)
            : base(options)
        {
        }

        public DbSet<Padilla_Gabriel_Laboratorio_CodeFirst_2023_20.Models.Registro_VacModel> Registro_VacModel { get; set; } = default!;
    }
}
