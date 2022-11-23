using System.ComponentModel.DataAnnotations;

namespace EntityFrameWork02.Models
{
    public class City
    {
        [Key]
        public string Id { get; set; }

        public string Name { get; set; }

        public string PostNumber { get; set; }

        public DateTime Register { get; set; }

        public List<Person> People { get; set; } = new List<Person>();
        public List<Country> Country { get; set; } = new List<Country>();
        public List<Language> Language { get; set; } = new List<Language>();
    }
}
