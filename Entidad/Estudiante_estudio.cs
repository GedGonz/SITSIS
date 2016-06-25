using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Estudiante_estudio
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string estudio { get; set; }
        [Required]
        public int ano { get; set; }
        [Required]
        public string presedencia { get; set; }
        [Required]
        public int tipo { get; set; }
        public virtual Estudiante Estudiante { get; set; }
    }
}
