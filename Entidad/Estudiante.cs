using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Estudiante
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string carnet { get; set; }
        public int estado { get; set; }
        public virtual Persona Persona { get; set; } 
        public virtual ICollection<Estudiante_estudio> Estudiante_estudios { get; set; }
        public virtual ICollection<Estudiante_trabajo> Estudiante_trabajos { get; set; }
        public virtual ICollection<Padre> Padres { get; set; }
    }
}
