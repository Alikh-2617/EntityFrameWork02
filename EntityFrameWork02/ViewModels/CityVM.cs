using EntityFrameWork02.Models;

namespace EntityFrameWork02.ViewModels
{
    public class CityVM
    {
        public City City { get; set; }

        public List<City> Cities { get; set; } // = new List<City>();

        public string GetCity { get; set; } = "";
    }
}
