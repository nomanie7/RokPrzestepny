using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using RokPrzestepny.Models;

namespace RokPrzestepny.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public Person Person { get; set; }

        public IList<Person> People;

        public void OnGet()
        {
            
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                HttpContext.Session.SetString("Data", JsonConvert.SerializeObject(Person));
                if (Person.FirstName.EndsWith("a") && Person.Year % 4 == 0)
                    TempData["AlertMessage"] = Person.FirstName + " urodziła się w " + Person.Year + " roku. To był rok przestępny.";
                else if (Person.FirstName.EndsWith("a") && Person.Year % 4 != 0)
                    TempData["AlertMessage"] = Person.FirstName + " urodziła się w " + Person.Year + " roku. To nie był rok przestępny.";
                else if (Person.Year % 4 == 0)
                    TempData["AlertMessage"] = Person.FirstName + " urodził się w " + Person.Year + " roku. To był rok przestępny.";
                else if (Person.Year % 4 != 0)
                    TempData["AlertMessage"] = Person.FirstName + " urodził się w " + Person.Year + " roku. To nie był rok przestępny.";
                return RedirectToPage("./Index");
            }
            return Page();
        }

    }
}