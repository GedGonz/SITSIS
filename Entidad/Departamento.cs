using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.ComponentModel.DataAnnotation;
namespace Entidad
{
    public class Departamento
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string departamento { get; set; }
        public string descripcion { get; set; }
        public virtual Pais Pais { get; set; }
        public virtual ICollection<Municipio> Municipios { get; set; }
    }
}
