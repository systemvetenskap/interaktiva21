using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DemoInteraktiva.Models.ViewModels
{
    public class CovidViewModel
    {
        private readonly IEnumerable<CountryDto> countries;

        public string SelectedCountry { get; set; }
        public IEnumerable<SelectListItem> Countries 
        {
            #region Fyll data i vår listbox
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
            #endregion
        }            

        public CovidViewModel(IEnumerable<CountryDto> countries)
        {
            this.countries = countries.OrderBy(x => x.Country);
        }
    }
}