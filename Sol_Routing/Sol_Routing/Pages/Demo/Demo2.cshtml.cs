using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Sol_Routing
{
    public class Demo2Model : PageModel
    {
        public void OnGet()
        {

        }

        [BindProperty(SupportsGet =true)]
        public int id { get; set; }

        // Using Custom Handler
        public void OnGetView()
        {

        }
    }
}