using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Sol_Routing
{
    public class Demo4Model : PageModel
    {

        [BindProperty(SupportsGet =true)]
        public int id { get; set; }

        public void OnGet()
        {

        }

    }
}