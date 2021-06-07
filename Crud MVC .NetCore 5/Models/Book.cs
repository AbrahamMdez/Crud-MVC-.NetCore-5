using System;
using System.ComponentModel.DataAnnotations;

namespace Crud_MVC_.NetCore_5.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El titulo debe ser obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Titulo")]
        public string Title { get; set; }

        [Required(ErrorMessage = "La descripción debe ser obligatoria")]
        [StringLength(50, ErrorMessage = "El {0} debe tener al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Descripción")]
        public string Description { get; set; }

        [Required(ErrorMessage = "La fecha debe ser obligatoria")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha")]
        public DateTime PublicDate { get; set; }

        [Required(ErrorMessage = "El autor debe ser obligatoria")]
        public string Author { get; set; }

        [Required(ErrorMessage = "El precio debe ser obligatorio")]
        public int Price { get; set; }
    }
}
