﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult GetAll()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Update() 
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }

    }
}
