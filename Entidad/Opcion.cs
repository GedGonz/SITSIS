using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Opcion
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string opcion { get; set; }
        public string descripcion { get; set; }
        public int id_padre { get; set; }
        public int estado { get; set; }
        public virtual Modulo Modulo { get; set; }
        public virtual ICollection<Usuario_opcion> Usuario_opcions { get; set; }
    }
}
