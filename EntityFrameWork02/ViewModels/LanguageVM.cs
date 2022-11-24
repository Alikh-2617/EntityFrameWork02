using EntityFrameWork02.Models;

namespace EntityFrameWork02.ViewModels
{
    public class LanguageVM
    {
        public Language Language  { get; set; }

        public List<Language> Languagies { get; set; }  = new List<Language>();

        public string GetLanguage { get; set; } = "";
    }
}
