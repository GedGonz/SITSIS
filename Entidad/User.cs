using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Entidad
{
    public class User : IdentityUser
    {
        public virtual Persona Persona { get; set; }
        public virtual Rol Rol { get; set; }
        public virtual ICollection<Usuario_opcion> Usuario_opcions { get; set; }
    }
}
