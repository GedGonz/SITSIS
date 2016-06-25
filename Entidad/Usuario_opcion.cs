using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Usuario_opcion
    {
        [Key]
        public int Id { get; set; }
        public virtual User User { get; set; }
        public virtual Opcion Opcion { get; set; }
        public int estado { get; set; }
        
    }
}
