using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFEscuela.Models
{
    [Table("Alumno")]
    public class Alumno
    {
        public int AlumnoId { get; set; }

        [Column(TypeName = "varchar")] // tipo de dato en sql
        [StringLength(50)] // long de la cadena
        [Required] // es obligatorio. No acepta nulos 
        public string Name { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Apellido { get; set; }
        public DateTime? FechaNacimiento { get; set; }

        //public Profesor Profesor { get; set; }
    }
}
