using EntityFrameWork02.Models;

namespace EntityFrameWork02.ViewModels
{
    public class PersonVM
    {
        public Person Person { get; set; } = new Person();

        public List<Person> People { get; set; } = new List<Person>();

        public string GetPerson { get; set; } = "";
    }
}
