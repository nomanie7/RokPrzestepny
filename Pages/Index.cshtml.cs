using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using RokPrzestepny.Models;
using RokPrzestepny.Data;

namespace RokPrzestepny.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly PeopleContext _context;
        public IndexModel(ILogger<IndexModel> logger, PeopleContext context)
        {
            _logger = logger;
            _context = context;
        }

        [BindProperty]
        public Person Person { get; set; }

        public IList<Person> People { get; set; }

 
        public void OnGet()
        {
//          People = _context.Person.ToList();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                HttpContext.Session.SetString("Data", JsonConvert.SerializeObject(Person));
                if (Person.FirstName.EndsWith("a") && Person.Year % 4 == 0)
                {
                    TempData["AlertMessage"] = Person.FirstName + " urodziła się w " + Person.Year + " roku. To był rok przestępny.";
                    Person.Result = "rok przestepny";
                }
                else if (Person.FirstName.EndsWith("a") && Person.Year % 4 != 0)
                {
                    TempData["AlertMessage"] = Person.FirstName + " urodziła się w " + Person.Year + " roku. To nie był rok przestępny.";
                    Person.Result = "rok nie przestepny";
                }
                else if (Person.Year % 4 == 0)
                {
                    TempData["AlertMessage"] = Person.FirstName + " urodził się w " + Person.Year + " roku. To był rok przestępny.";
                    Person.Result = "rok przestepny";
                }
                else if (Person.Year % 4 != 0)
                {
                    TempData["AlertMessage"] = Person.FirstName + " urodził się w " + Person.Year + " roku. To nie był rok przestępny.";
                    Person.Result = "rok nie przestepny";
                }
                Person.Date = DateTime.Now;
                _context.Person.Add(Person);
                _context.SaveChanges();
                return RedirectToPage("./Index");
            }
            return Page();
        }

    }
}