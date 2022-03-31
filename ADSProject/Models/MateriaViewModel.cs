using ADSProject.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ADSProject.Models
{
    public class MateriaViewModel
    {
        [Display(Name = "ID")]
        public int idMateria { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "La longitud del campo no debe ser mayor a 50 caracteres ni menor de 5 caracteres.")]
        [Display(Name = "Materia")]
        public string nombreMateria { get; set; }

    }
}
