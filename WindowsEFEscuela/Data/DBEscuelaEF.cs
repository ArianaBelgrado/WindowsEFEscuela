using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WindowsEFEscuela.Models;

namespace WindowsEFEscuela.Data
{
    public class DBEscuelaEF : DbContext 
    {
        // Constructor
        public DBEscuelaEF() : base("KeyDB") { }

        // Propiedades DBSET
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Aula> Aulas { get; set; }
    }
}
