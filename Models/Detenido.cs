using System.ComponentModel.DataAnnotations;

namespace MigracionApp.Web.Models
{
    public class Detenido
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "La fecha de detención es obligatoria")]
        [Display(Name = "Fecha de Detención")]
        public DateTime FechaDetencion { get; set; }

        [Required(ErrorMessage = "El nombre completo es obligatorio")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres")]
        [Display(Name = "Nombre Completo")]
        public string NombreCompleto { get; set; } = string.Empty;

        [Required(ErrorMessage = "El número de pasaporte es obligatorio")]
        [StringLength(20, ErrorMessage = "El número de pasaporte no puede exceder los 20 caracteres")]
        [Display(Name = "Número de Pasaporte")]
        public string NumeroPasaporte { get; set; } = string.Empty;

        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria")]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "La latitud es obligatoria")]
        [Range(-90, 90, ErrorMessage = "La latitud debe estar entre -90 y 90")]
        public double Latitud { get; set; }

        [Required(ErrorMessage = "La longitud es obligatoria")]
        [Range(-180, 180, ErrorMessage = "La longitud debe estar entre -180 y 180")]
        public double Longitud { get; set; }
    }
}