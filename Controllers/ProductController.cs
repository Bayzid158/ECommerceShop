using Microsoft.AspNetCore.Mvc;

namespace ECommerceWebsite.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product/SingleProduct
        public IActionResult SingleProduct()
        {
            return View();
        }
    }
}
