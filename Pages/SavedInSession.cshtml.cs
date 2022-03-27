using RokPrzestepny.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace RokPrzestepny.Pages
{
    public class SavedInSessionModel : PageModel
    {
        public Person Person { get; set; }

        public IList<Person> people;

        public void OnGet()
         {
            var Data = HttpContext.Session.GetString("Data");
            if (Data != null)
                Person = JsonConvert.DeserializeObject<Person>(Data);
            }

        }
    }

