﻿using Microsoft.AspNetCore.Mvc;

namespace WithMe.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
