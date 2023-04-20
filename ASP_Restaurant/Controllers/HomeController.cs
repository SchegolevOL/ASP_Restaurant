using ASP_Restaurant.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASP_Restaurant.Controllers
{
    public class HomeController : Controller
    {
        private readonly RestaurantDbContext restaurantDbContext;
        public HomeController(RestaurantDbContext restaurantDbContext)
        {
            this.restaurantDbContext = restaurantDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Booking()
        {
            return View();
        }
        public IActionResult Menu()
        {

            ViewBag.menuNames = restaurantDbContext.menuNames.ToList();

            return View(this.restaurantDbContext.menuPositions.ToList());
        }
        public IActionResult About()
        {
            #region TestAddTeamToList
            CardTeam cardTeam = new CardTeam()
            {
                Name = "Oleg Schegolev",
                ImageUrl = @"/img/team-1.jpg",
                Designation = "Master",
                Facebook = "https://github.com/SchegolevOL",
                instagram = "https://github.com/SchegolevOL",
                Twitter = "https://github.com/SchegolevOL",
                MasterChefs = true
            };
            List<CardTeam> cardTeams = new List<CardTeam>();
            for (int i = 0; i < 4; i++)
            {
                cardTeams.Add(cardTeam);
            }
            #endregion

            return View(cardTeams);
        }
        public IActionResult Services()
        {
            return View();
        }
        public IActionResult Team()
        {
            #region TestAddTeamToList
            CardTeam cardTeam = new CardTeam()
            {
                Name="Oleg Schegolev",
                ImageUrl = @"/img/team-1.jpg",
                Designation ="Master",
                Facebook= "https://github.com/SchegolevOL",
                instagram= "https://github.com/SchegolevOL",
                Twitter = "https://github.com/SchegolevOL"
            };
            List<CardTeam> cardTeams = new List<CardTeam>();
            for (int i = 0; i < 8; i++)
            {
                cardTeams.Add(cardTeam);
            }
            #endregion



            return View(cardTeams);
        }

        public IActionResult Admin()
        {
            return View();
        }
        public IActionResult Testimonial()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}