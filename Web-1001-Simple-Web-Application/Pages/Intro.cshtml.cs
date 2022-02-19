using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web_1001_Simple_Web_Application.Pages
{
    public class IntroModel : PageModel
    {
        public int First_Number { get; set; }

        public int Second_Number { get; set; }

        public int Output { get; set; }

        public void OnGet()
        {
        }
    }
}
