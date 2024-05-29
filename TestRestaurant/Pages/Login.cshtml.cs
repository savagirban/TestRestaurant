using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestaurantFis.Models.Domain.Usecase;
using RestaurantFis.Models.Mock.Data.Repos;

namespace TestRestaurant.Pages
{
    public class LoginModel : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost()
        {
            var username = Request.Form["casutaUsername"];
            var parola = Request.Form["casutaParola"];
            var repoUtilizatori = new MockRepoUtilizator();
            var autentificator = new ServiciuAutentificare(repoUtilizatori);
            var user = autentificator.Autentificare(username!, parola!);
            if (user != null)
            {
                Console.WriteLine("Utilizatorul" + $"{user.Nume} {user.Prenume}" + " s-a autentificat!");
            }
            
        }
    }
}
