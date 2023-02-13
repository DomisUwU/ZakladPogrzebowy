using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZakladPogrzebowy.Models;

namespace ZakladPogrzebowy.Pages
{
    public class AddZakopkeModel : PageModel
    {
        [BindProperty]
        public Zmarlak MojZmarlak { get; set; }
        public List<string> KindOf { get; set; }//select
        public List<string> Coffin { get; set; }//radio
        public AddZakopkeModel()
        {
            Coffin = new List<string> { "Drewno sosnowe", "Drewno debowe", "Drewno œwierkowe" };

            KindOf = new List<string>
            {
                "Tradycyjny","Kremacja","Pogrzeb œwiecki","Pogrzeb zielony","Pogrzeb bezpoœredni"
            };

            if (MojZmarlak == null)
            {
                MojZmarlak = new Zmarlak();
            }
            MojZmarlak.Bonusses = new List<Bonusy>//checkbox
            {
                new Bonusy { Bonus = "Clown"},
                new Bonusy { Bonus = "Seans horrorow" },
                new Bonusy { Bonus = "Zagranie z jubilatem" },
                new Bonusy { Bonus = "Stypa" },
                new Bonusy { Bonus = "Zenek Martyniuk UwU" },
                new Bonusy { Bonus = "Popijawa" }
            };
        }
public void OnGet()
        {
        }
        public void OnPost()
        {
            ViewData["post"] = true;
            if (ModelState.IsValid)
            {
                var result = MojZmarlak;
            }
            else
            {

            }
        }
    }
}
