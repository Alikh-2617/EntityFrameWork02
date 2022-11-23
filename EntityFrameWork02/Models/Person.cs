using System.ComponentModel.DataAnnotations;

namespace EntityFrameWork02.Models
{
    public class Person
    {
        [Key]
        public string Id { get; set; }

        public string  Name { get; set; }

        public int Age { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime Register { get; set; }

        public List<Language> Languages { get; set; } = new List<Language>();
        public List<City> Citys { get; set; } = new List<City>();
        public List<Country> Countrys { get; set; } = new List<Country>();
    }
}
