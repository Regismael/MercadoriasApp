﻿using Microsoft.AspNetCore.Mvc;

namespace MercadoriasApp.Presentation.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
