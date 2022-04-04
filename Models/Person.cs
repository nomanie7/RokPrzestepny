using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RokPrzestepny.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Display(Name = "Twoje imię")]
        [Required(ErrorMessage = "Pole jest obowiązkowe")]
        [StringLength(100, MinimumLength = 3)]
        [Column(TypeName = "varchar(100)")]
        [MaxLength(100)]
        public string? FirstName { get; set; }
        [Display(Name = "Nazwisko")]
        [StringLength(100, MinimumLength = 3)]
        [Column(TypeName = "varchar(100)")]
        [MaxLength(100)]
        public string? LastName { get; set; }
        [Display(Name = "Wynik")]
        [MaxLength(100)]
        public string? Result { get; set; }
        [Display(Name = "Data")]
        public DateTime Date { get; set; }
        [Display(Name = "Twój rok urodzenia")]
        [Required(ErrorMessage = "Pole jest obowiązkowe")]
        [Range(1899, 2022, ErrorMessage = "Oczekiwana wartość {0} z zakresu {1} i {2}.")]
        public int? Year { get; set; }

    }
}
