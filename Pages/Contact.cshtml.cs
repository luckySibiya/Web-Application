using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication.Pages
{
    public class ContactModel : PageModel
    {
        public bool hasData = false;
        public string firstname = "";
        public string lastname = "";
        public string message = "";

        public void OnGet()
        {
        }

        public void OnPost()
        {
            hasData = true;
            firstname = Request.Form["firstname"];
            lastname = Request.Form["lastname"];
            message = Request.Form["message"];

        }
    }
}
