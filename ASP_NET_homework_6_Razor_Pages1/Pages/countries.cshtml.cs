using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_NET_homework_6_Razor_Pages1.Pages
{
    public class countriesModel : PageModel
    {
        public class Country
        {
            public string Name { get; set; }
            public string Area { get; set; } // in sq km
            public string Population { get; set; }
            
            public Country(string name, string area, string population)
            {
                Name = name;
                Area = area;
                Population = population;
            }
        }
        public List<Country> countries;

        public void OnGet()
        {
            countries = new List<Country>()
            {
                new Country("Brazil", "8 515 770", "212 583 750"),
                new Country("Mexico", "1 964 375", "130 154 247"),
                new Country("Sweden", "450 295", "10 588 230"),
                new Country("Uzbekistan", "447 400", "37 543 167"),
                new Country("Paaraguay", "406 752", "6 109 644"),
                new Country("Japan", "377 915", "123 590 000"),
                new Country("Germany", "357 022", "83 465 411"),
                new Country("Norway", "323 802", "5 585 044"),
                new Country("Malasia", "329 847", "34 112 400"),
                new Country("Oman", "309 500", "5 268 072"),
                new Country("Nepal", "147 181", "29 164 578"),
                new Country("Sudan", "1 861 484", "50 448 963")
            };
        }
    }
}
