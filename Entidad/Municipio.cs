using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Municipio
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string municipio { get; set; }
        public string descripcion { get; set; }
        public virtual Departamento Departamento { get; set; }
        public virtual ICollection<Persona> Personas { get; set; }

    }
}
