using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ZakladPogrzebowy.Models
{
    public class Zmarlak
    {
        [Required(ErrorMessage = "Podaj imię")]
        [DisplayName("Podaj imię")]
        [MinLength(3, ErrorMessage = "Muszą być 3 litery")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Podaj nazwisko")]
        [DisplayName("Podaj nazwisko")]
        [MinLength(3, ErrorMessage = "Muszą być 3 litery")]
        public string? LastName { get; set; }

        [DisplayName("Numer Grobu")]
        public int GraveNumber { get; set; }

        [DisplayName("Data Pogrzebu")]
        public DateOnly DateOfTheFuneral { get; set; }

        [DisplayName("Rodzaj Trumny")]
        public string Coffin { get; set; } = "Drewno sosnowe";

        [DisplayName("Rodzaj Pogrzebu")]
        public string KindOfFuneral { get; set; }

        [DisplayName("Dodatkowe Bonusy")]
        public  List<Bonusy> Bonusses { get; set; }

    }
}
