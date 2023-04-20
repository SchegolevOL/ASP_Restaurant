using ASP_Restaurant.Helpers;
using ASP_Restaurant.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Hosting;

namespace ASP_Restaurant.Controllers
{
    public class AdminController : Controller
    {
        private readonly RestaurantDbContext restaurantDbContext;
        public AdminController(RestaurantDbContext restaurantDbContext)
        {
            this.restaurantDbContext = restaurantDbContext;
        }

        public IActionResult Admin()
        {
            return View();
        }
        public IActionResult ListMenuName()
        {
            return View(this.restaurantDbContext.menuNames.ToArray());
        }
        [HttpGet]
        public IActionResult AddMenu()
        {
            ViewBag.menuNames = new MultiSelectList(restaurantDbContext.menuNames, "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(MenuPosition menuPosition, IFormFile image, int[] menuNames)
        {

            var path = await FileLoadHelper.UploadAsync(image);
            menuPosition.ImageUrl = path;

            //if (ModelState.IsValid)
            //{
            //    await restaurantDbContext.AddAsync(menuPosition);
            //    await restaurantDbContext.SaveChangesAsync();
            //    return RedirectToAction("Admin", "Admin");
            //}
            //return View();

            await restaurantDbContext.AddAsync(menuPosition);
            await restaurantDbContext.SaveChangesAsync();
            for (int i = 0; i < menuNames.Length; i++)
            {
                await restaurantDbContext.
                    menuNamePositions.
                    AddAsync(new MenuNamePosition { MenuNameId = menuNames[i], MenuPositionId = menuPosition.Id });
            }
            await restaurantDbContext.SaveChangesAsync();
            return RedirectToAction("ListMenuPosition", "Admin");
        }
        public IActionResult ListMenuPosition()
        {

            return View(this.restaurantDbContext.menuPositions.ToList());
        }


    }
}
