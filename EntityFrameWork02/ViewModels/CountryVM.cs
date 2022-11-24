using EntityFrameWork02.Models;

namespace EntityFrameWork02.ViewModels
{
    public class CountryVM
    {
        public Country Country { get; set; }

        public List<Country> Countries { get; set; }  = new List<Country>();

        public string GetCountry { get; set; } = "";
    }
}
