﻿using Microsoft.AspNetCore.Mvc;

namespace Login.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
