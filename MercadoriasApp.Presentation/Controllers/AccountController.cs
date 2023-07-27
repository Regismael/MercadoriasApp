using ContasApp.Data.Entities;
using ContasApp.Data.Repositories;
using ContasApp.Presentation.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace ContasApp.Presentation.Controllers
{
    /// <summary>
    /// Classe de controle do Asp.Net MVC
    /// </summary>
    public class AccountController : Controller
    {
        /// <summary>
        /// Método para abrir a página /Account/Login
        /// </summary>
        public IActionResult Login()
        {
            return View();
        }
        /// <summary>
        /// Método para abrir a página /Account/Register
        /// </summary>
        public IActionResult Register()
        {
            return View();
        }
        /// <summary>
        /// Método para capturar o SUBMIT POST da página /Account/Register
        /// </summary>
        [HttpPost] //Receber o SUBMIT POST do formulário
        public IActionResult Register(AccountRegisterViewModel model)
        {
            //verificar se todos os campos passaram nas regras de validação
            if (ModelState.IsValid)
            {
                try
                {
                    var clienteRepository = new ClienteRepository();
                    if (clienteRepository.GetByEmail(model.Email) != null)
                    {
                        TempData["Mensagem"] = "O email informado está cadastrado, por favor tente outro.";

                    }
                    else
                    {

                        //capturando os dados do usuário
                        var cliente = new Cliente();
                        cliente.Id = Guid.NewGuid();
                        cliente.Nome = model.Nome;
                        cliente.Email = model.Email;
                        cliente.Senha = model.Senha;
                        cliente.DataHoraCriacao = DateTime.Now;
                        //gravando o usuário no banco de dados
                        clienteRepository.Add(cliente);
                        TempData["Mensagem"] = "Parabéns, sua conta de cliente foi cadastrada com sucesso!";
                    }
                }
                catch (Exception e)
                {
                    TempData["Mensagem"] = e.Message;
                }
            }
            return View();
        }
        /// <summary>
        /// Método para abrir a página /Account/ForgotPassword
        /// </summary>
        public IActionResult ForgotPassword()
        {
            return View();
        }
    }
}