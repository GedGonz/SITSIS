using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Docente_estudio{
    
        [Key]
        public int Id{get; set;}
        public string estudio { get; set;}
        public int Ano { get; set;}
        public virtual Docente Docente { get; set; }
    }
}
