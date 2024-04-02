using CLDV6211_POE_KhumaloCraft.Models;
using Microsoft.AspNetCore.Mvc;

namespace CLDV6211_POE_KhumaloCraft.Controllers
{
  public class CraftsController : Controller
  {
    public IActionResult Index()
    {
      var crafts = GetCrafts();
      return View(crafts);
    }

    private List<Crafts> GetCrafts()
    {
        return new List<Crafts>
        {
            new Crafts { Id = 1, Name = "Easter", Description = "Ceramic Pots from the easter collection", ImageUrl = "/images/Craft1.jpg", Price = 80 },
            new Crafts { Id = 2, Name = "Milk", Description = "Ceramic Pots from the milk collection", ImageUrl = "/images/Craft2.jpg", Price = 100 },
            new Crafts { Id = 3, Name = "Coconut", Description = "Ceramic Pots from the coconut collection", ImageUrl = "/images/Craft3.jpg", Price = 70 },
            new Crafts { Id = 4, Name = "Leaf", Description = "Ceramic Pots from the leaf collection", ImageUrl = "/images/Craft4.jpg", Price = 100 },
            new Crafts { Id = 5, Name = "Eggshell", Description = "Ceramic Pots from the eggshell collection", ImageUrl = "/images/Craft5.jpg", Price = 90 },
            new Crafts { Id = 6, Name = "Spotted", Description = "Ceramic Pots from the spotted collection", ImageUrl = "/images/Craft6.jpg", Price = 120 }
        };
    }
  }
}
