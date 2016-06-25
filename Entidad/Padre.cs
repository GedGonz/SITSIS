using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Padre
    {
        [Key]
        public int Id { get; set; }
        public virtual Estudiante Estudiante { get; set; }
        public virtual Persona Persona { get; set; }
    }
}
