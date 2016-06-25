using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Estudiante_trabajo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string cargo { get; set; }
        [Required]
        public string tiepo { get; set; }
        public int telefono { get; set; }
        [Required]
        public string direccion { get; set; }
        public virtual Estudiante Estudiante { get; set; }
    }
}
