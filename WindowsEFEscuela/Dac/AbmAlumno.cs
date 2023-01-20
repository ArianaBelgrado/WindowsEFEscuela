using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFEscuela.Data;
using WindowsEFEscuela.Models;

namespace WindowsEFEscuela.Dac
{
    public static class AbmAlumno
    {
        // Creamos instancia de nuestro Dbcontext
        private static DBEscuelaEF context = new DBEscuelaEF();

        public static List<Alumno> SelectAll() 
        {
            return context.Alumnos.ToList();
        }
        
        public static Alumno SelectById( int id) 
        {
            return context.Alumnos.Find(id);
        }

        public static int Insert (Alumno alumno)
        {
            context.Alumnos.Add(alumno);

            return context.SaveChanges();
        }

        public static int Update (Alumno alumno) 
        {
            Alumno alumnoOrigen = context.Alumnos.Find(alumno.AlumnoId);

            alumnoOrigen.Name = alumno.Name;
            alumnoOrigen.Apellido = alumno.Apellido;
            alumnoOrigen.FechaNacimiento = alumno.FechaNacimiento;

            return context.SaveChanges();
        }
         
        public static int Delete (Alumno alumno)
        {
            Alumno alumnoOrigen = context.Alumnos.Find(alumno.AlumnoId);

            if( alumnoOrigen != null) 
            {
                context.Alumnos.Remove(alumnoOrigen);
                return context.SaveChanges();
            }
            return 0;
        }
    }
}
