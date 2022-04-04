using RokPrzestepny.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using RokPrzestepny.Data;

namespace RokPrzestepny.Pages
{
    public class SavedInSessionModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly PeopleContext _context;
        public SavedInSessionModel(ILogger<IndexModel> logger, PeopleContext context)
        {
            _logger = logger;
            _context = context;
        }

        [BindProperty]
        public Person Person { get; set; }
        public IList<Person> People { get; set; }

        public void OnGet()
        {
            People = _context.Person.ToList();
        }
    }
}

