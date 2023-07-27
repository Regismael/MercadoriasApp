using Microsoft.AspNetCore.Mvc;

namespace MercadoriasApp.Presentation.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Método para abrir a página /Home/Index
        /// </summary>
        public IActionResult Index()
        {
            return View();
        }
    }
}
