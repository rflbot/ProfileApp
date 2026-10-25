using Microsoft.AspNetCore.Mvc;
using ProfileApp.Models;
using System.Collections.Generic;

namespace ProfileApp.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            var profiles = new List<ProfileModel>
            { new () { Name = "Rafael A. Basanta", Course = "BSCS", Email = "rafaelbasanta32@gmail.com", GitHub = "https://github.com/rflbot",  ImageUrl ="/images/Rafael.jpg" },
              new () { Name = "David Justiniano", Course = "BSCS", Email = "justinianodavid0104@email.com", GitHub = "https://github.com/vid0103",  ImageUrl ="/images/David.jpg" }
        };
            return View(profiles);
        }
    }
}
