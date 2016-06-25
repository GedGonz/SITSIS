using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Rol
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string rol { get; set; }
        public string descripcion { get; set; }
        public virtual ICollection<User> Users { get; set; }

    }
}
