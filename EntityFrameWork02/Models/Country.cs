using System.ComponentModel.DataAnnotations;

namespace EntityFrameWork02.Models
{
    public class Country
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }

        public DateTime Register { get; set; }

        public List<City> City { get; set; } = new List<City>();
        public List<Person> Person { get; set; } = new List<Person>();  
        public List<Language> Language { get; set; } = new List<Language>();
    }
}
