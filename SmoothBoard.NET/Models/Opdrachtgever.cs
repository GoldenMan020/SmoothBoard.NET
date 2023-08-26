using System.ComponentModel.DataAnnotations;

namespace SmoothBoard.NET.Models
{
    public class Opdrachtgever
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Naam is verplicht.")]
        public string Naam { get; set; }

        [Required(ErrorMessage = "Adres is verplicht.")]
        public string Adres { get; set; }

        [Required(ErrorMessage = "Telefoonnummer is verplicht.")]
        [Display(Name = "Telefoonnummer")]
        public string Telefoonnummer { get; set; }

        [Required(ErrorMessage = "E-mail is verplicht.")]
        [EmailAddress(ErrorMessage = "Voer een geldig e-mailadres in.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Brengdatum is verplicht.")]
        [DataType(DataType.Date)]
        public DateTime BrengDatum { get; set; }

        [Required(ErrorMessage = "Ophaaldatum is verplicht.")]
        [DataType(DataType.Date)]
        [Display(Name = "Ophaaldatum")]
        public DateTime OphaalDatum { get; set; }

        [Required(ErrorMessage = "Lengte moet tussen 260 en 370 liggen.")]
        [Range(260, 370, ErrorMessage = "Lengte moet tussen 260 en 370 liggen.")]
        public int Lengte { get; set; }

        [Required(ErrorMessage = "Breedte moet tussen 65 en 85 liggen.")]
        [Range(65, 85, ErrorMessage = "Breedte moet tussen 65 en 85 liggen.")]
        public int Breedte { get; set; }
    }

    
}
