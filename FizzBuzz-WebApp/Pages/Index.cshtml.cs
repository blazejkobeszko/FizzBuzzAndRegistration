using FizzBuzz_WebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzz_WebApp.Models;
using FizzBuzz_WebApp.Data;
using Microsoft.AspNetCore.Identity;

namespace FizzBuzz_WebApp.Pages
{
    public class IndexModel : PageModel
    {


        private readonly ILogger<IndexModel> _logger;

        private readonly FBContext _context;

        private UserManager<IdentityUser> _UserManager;

        public IList<Main> Historia { get; set; }


        [BindProperty]
        public Main FizzBuzz { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Name { get; set; }

        public IndexModel(ILogger<IndexModel> logger, FBContext context, UserManager<IdentityUser> UserManager)
        {
            _logger = logger;
            _context = context;
            _UserManager = UserManager;
        }

        public void OnGet()
        {
            Historia = _context.FizzBuzzTable.ToList();
        }
        public async Task<IActionResult> OnPostAsync()
        {

            if (ModelState.IsValid)
            {
                FizzBuzz.Fizz();
               // FizzBuzz.Wynik = _UserManager.GetUserName(User);
               FizzBuzz.uzytkownik= _UserManager.GetUserName(User);
                _context.FizzBuzzTable.Add(FizzBuzz);
                await _context.SaveChangesAsync();
                HttpContext.Session.SetString("SessionAddress", JsonConvert.SerializeObject(FizzBuzz));
                ViewData["Message"] = FizzBuzz.Wynik;
                return Page();
            }


            //OnGet();
            return Page();
        }

        


}
}
