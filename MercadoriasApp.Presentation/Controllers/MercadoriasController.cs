using Microsoft.AspNetCore.Mvc;
namespace ContasApp.Presentation.Controllers
{
    public class MercadoriasController : Controller
    {
        /// <summary>
        /// Método para abrir a página /Mercadorias/Cadastro
        /// </summary>
        public IActionResult Cadastro()
        {
            return View();
        }
        /// <summary>
        /// Método para abrir a página /Mercadorias/Consulta
        /// </summary>
        public IActionResult Consulta()
        {
            return View();
        }
        /// <summary>
        /// Método para abrir a página /Mercadorias/Edicao
        /// </summary>
        public IActionResult Edicao()
        {
            return View();
        }
    }
}