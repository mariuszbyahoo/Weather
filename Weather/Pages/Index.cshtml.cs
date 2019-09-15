using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Weather.Core;

namespace Weather.Pages
{
    public class IndexModel : PageModel
    {
        WeatherModel weather { get; set; }
        public void OnGet()
        {
            weather = 
        }
    }
}
