using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string primernombre { get; set; }
        public string segundonombre { get; set; }
        [Required]
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        [Required]
        public DateTime edad { get; set; }
        [Required]
        public string tiposanguineo { get; set; }
        public string foto { get; set; }
        public string cedula { get; set; }
        [Required]
        public string direccion { get; set; }
        [Required]
        public string estadocivil { get; set; }
        public int celular { get; set; }
        public int telefono { get; set; }
        [Required]
        public string genero { get; set; }
        public string estado { get; set; }

        public DateTime fechacre { get; set; }

        public virtual ICollection<User> Users { get; set; }
        public virtual Municipio Municipio { get; set; }
        public virtual ICollection<Docente> Docentes { get; set; }
        public virtual ICollection<Nacionalidad> Nacionalidads { get; set; }
        public virtual ICollection<Estudiante> Estudiantes { get; set; }
        public virtual ICollection<Padre> Padres { get; set; }
    }
    }

