using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Weather.Pages
{
    public class IndexModel : PageModel
    {
        public string data{ get; set; }
        public HttpWebRequestHandler handler = new HttpWebRequestHandler();
        public void OnGet()
        {
            data = handler.GetWeather("http://api.openweathermap.org/data/2.5/weather?q=Warsaw,pl&APPID=bcb0c61841c80cc665a6cec5e9fbd83c");
        }
    }
}
