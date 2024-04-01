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
            new Crafts { Id = 1, Name = "Craft1", Description = "Ceramic Pots from the easter collection", ImageUrl = "/images/Craft1.jpg", Price = 80 },
            new Crafts { Id = 2, Name = "Craft2", Description = "Ceramic Pots from the eggshell collection", ImageUrl = "/images/Craft2.jpg", Price = 100 },
            new Crafts { Id = 3, Name = "Craft3", Description = "Ceramic Pots from the coconut collection", ImageUrl = "/images/Craft3.jpg", Price = 70 }
        };
    }
  }
}
