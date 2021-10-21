using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DemoInteraktiva.Models.ViewModels
{
    public class CovidViewModel
    {
        private readonly List<CountryDto> countries;

        public string SelectedCountry { get; set; }
        public IEnumerable<SelectListItem> Countries 
        { 
            get
            {
                if (countries != null)
                {
                    return countries.Select(x =>
                        new SelectListItem()
                        {
                            Text = x.Country,
                            Value = x.Slug
                        });
                }
                return null;
            }
        }            

        public CovidViewModel(List<CountryDto> countries)
        {
            this.countries = countries;
        }
    }
}