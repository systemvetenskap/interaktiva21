using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoInteraktiva.Models.ViewModels
{
    public class HomeViewModel
    {
        [DisplayFormat(DataFormatString ="{0:N0} st")]
        [DisplayName("Totalt bekräftade fall")]
        public int TotalConfirmed { get; set; }
        public int ERik { get; set; }
    }
}
