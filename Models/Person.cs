using System.ComponentModel.DataAnnotations;

namespace RokPrzestepny.Models
{
    public class Person
    {
        [Display(Name = "Twoje imię")]
        [Required(ErrorMessage = "Pole jest obowiązkowe")]
        [StringLength(100,MinimumLength = 3)]
        public string? FirstName { get; set; }

        [Display(Name = "Twój rok urodzenia")]
        [Required(ErrorMessage = "Pole jest obowiązkowe")]
        [Range(1899, 2022, ErrorMessage = "Oczekiwana wartość {0} z zakresu {1} i {2}.")]
        public int? Year { get; set; }

    }
}
