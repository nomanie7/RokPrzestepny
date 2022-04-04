using Microsoft.EntityFrameworkCore;
using RokPrzestepny.Models;

namespace RokPrzestepny.Data
{
    public class PeopleContext : DbContext
    {
        public DbSet<Person> Person { get; set; }
        public PeopleContext(DbContextOptions options) : base(options) { }

    }

}
