using Microsoft.AspNetCore.Mvc;

namespace ECommerceWebsite.Controllers
{
    public class CartCheckoutController : Controller
    {
        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult Checkout()
        {
            return View();
        }
    }
}
