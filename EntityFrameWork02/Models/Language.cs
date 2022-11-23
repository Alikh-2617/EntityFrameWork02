
using System.ComponentModel.DataAnnotations;

namespace EntityFrameWork02.Models
{
    public class Language
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }

        public List<Person> Person { get; set; } = new List<Person>();
        public List<City> City { get; set; } = new List<City>();
        public List<Country> Country { get; set; } = new List<Country>();
    }
}
