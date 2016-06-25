using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Modulo
    {
    
        [Key]
        public int Id { get; set; }
        [Required]
        public string modulo { get; set; }
        public string descripcion { get; set; }
        public int estado { get; set; }
        public virtual ICollection<Opcion> Opcions { get; set; }
    }
}
