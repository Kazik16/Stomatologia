using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Stomatologia.Models
{
    public class Pacjent
    {
        public  string Id { get; set; }

        [StringLength(50, MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Używaj tylko liter!")]
        [Display(Name = "Imię")]
        [Required]
        public string FirstName { get; set; }

        [Required]
        //[EmailAddress(ErrorMessage = "Invalid Email Address")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Używaj tylko liter!")]
        [Display(Name = "Nazwisko")]
        public string Surname { get; set; }

        [RegularExpression(@"\d{11}", ErrorMessage = "Niepoprawny pesel!")]
        public string Pesel { get; set; }
        
        [RegularExpression(@"\d{9}", ErrorMessage = "Niepoprawny numer !")]
        [Display(Name = "Numer telefonu")]
        public string TelephoneNumber { get; set; }
    }
}