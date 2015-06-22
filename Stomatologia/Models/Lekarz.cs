using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Stomatologia.Models
{
    public class Lekarz
    {
        public string Id { get; set; }

        [StringLength(50, MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Używaj tylko liter!")]
        [Display(Name = "Imię")]
        [Required]
        public string FirstName { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Używaj tylko liter!")]
        [Display(Name = "Nazwisko")]
        public string Surname { get; set; }

        [RegularExpression(@"\d{11}", ErrorMessage = "Niepoprawny pesel!")]
        public string Pesel { get; set; }

        [RegularExpression(@"\d{9}", ErrorMessage = "Niepoprawny numer !")]
        [Display(Name = "Numer telefonu")]
        public string TelephoneNumber { get; set; }

        [NotMapped]
        public string FullName
        {
            get { return FirstName +  " " + Surname; }
        }
    }
}