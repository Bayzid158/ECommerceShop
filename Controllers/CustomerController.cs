using Microsoft.AspNetCore.Mvc;

namespace ECommerceWebsite.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult LoginRegister()
        {
            return View();
        }

        public IActionResult MyAccount()
        {
            return View();
        }
    }
}
