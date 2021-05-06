using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FizzBuzz_WebApp.Models
{
    public class Main
    {
       // private readonly UserManager<IdentityUser> _userManager;
        SignInManager<IdentityUser> SignInManager;
        UserManager<IdentityUser> UserManager;
        public int Id { get; set; }
        //[Display(Name = " ")]
        [Required(ErrorMessage = "Podaj liczbę z przedziału 1-1000.")]
        [Range(1, 1000)]
        public int Liczba { get; set; }

        public string Wynik { get; set; }
        public string uzytkownik { get; set; }
        
        //public IdentityUser user { get; set; }

       // [DataType(DataType.Time)]
        public DateTime Data
        {
            get; set;
        }
        //private async Task LoadAsync(IdentityUser user)
        //{ 
             
        //    string userName = await _userManager.GetUserNameAsync(user);
        //   // uzytkownik = userName;
        //}
        //public async Task<IActionResult> OnGetAsync()
        //{
        //    var user = await _userManager.GetUserAsync(User);
        //    if (user == null)
        //    {
        //        return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        //    }

        //    await LoadAsync(user);
        //    return Page();
        //}
        public void Fizz()
        {
           // var user = _userManager.GetUserAsync(User);
            Wynik = Wynik+ "Otrzymano: ";
            if (Liczba % 3 == 0)
                Wynik = Wynik+"Fizz";
            if (Liczba % 5 == 0)
                Wynik = Wynik + "Buzz";
            if (Liczba % 3 != 0 && Liczba % 5 != 0)
                Wynik = "Liczba "+Liczba.ToString()+ " nie spełnia kryteriów Fizz / Buzz";

            Data = DateTime.Now;
        }
    }
}

