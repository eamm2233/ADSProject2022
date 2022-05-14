using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ADSProject.Utils;
using System.ComponentModel.DataAnnotations;

namespace ADSProject.Models
{
    public class GrupoViewModel
    {
        [Display(Name = "ID")]
        [Key]
        public int idGrupo { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [Display(Name = "ID Carrera")]
        public int idCarrera { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [Display(Name = "ID Materia")]
        public int idMateria { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [Display(Name = "ID Profesor")]
        public int idProfesor { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [Display(Name = "Ciclo")]
        public string ciclo { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [Display(Name = "Año")]
        public string anio { get; set; }
        public bool estado { get; set; }
    }
}
