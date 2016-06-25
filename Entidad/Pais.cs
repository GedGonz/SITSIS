using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Pais
    {
        [Key]
        public int Id { get; set;}
        [Required]
        public string pais { get; set;}
        public string descripcion { get; set; }
        public virtual ICollection<Departamento> Departamentos { get; set; }
        public virtual ICollection<Nacionalidad> Nacionalidad { get; set; }
    }
}
