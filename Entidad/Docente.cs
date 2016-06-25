using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Docente
    {
        [Key]
        public int Id { get; set; }
        public string NumSeguro{get; set;}
        public virtual Persona Persona { get; set; }
        public virtual ICollection<Docente_estudio> Docente_estudios { get; set; }
    }
}
