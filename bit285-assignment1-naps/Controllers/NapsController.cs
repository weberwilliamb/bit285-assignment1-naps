﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using A1_Mod;

namespace bit285_assignment1_naps.Controllers
{
    public class NapsController : Controller
    {
        Repository repository;
        public NapsController(Repository user)
        {
            repository = user;
        }

        [HttpGet]
        public ViewResult AccountInfo()
        {
            return View ();
        }
        
        [HttpPost]
        public IActionResult AccountInfo(UserModel UI)
        {
            repository.AddUser(UI);
            return RedirectToAction("PasswordInfo", UI);
        }

        [HttpGet]
        public ViewResult PasswordInfo(UserModel UI)
        {
            return View();
        }

        [HttpPost]
        public IActionResult PasswordInfo(UserModel UI, String d)
        {
            repository.AddUser(UI);
            return RedirectToAction("SelectPassword", UI);
        }

        [HttpGet]
        public ViewResult SelectPassword(UserModel UI)
        {
            return View();
        }

        [HttpPost]
        public IActionResult SelectPassword(UserModel UI, String d)
        {
            repository.AddUser(UI);
            return RedirectToAction("ConfirmAccount", UI);
        }

        [HttpGet]
        public ViewResult ConfirmAccount(UserModel UI)
        {
            return View();
        }

        [HttpPost]
        public IActionResult ConfirmAccount(UserModel UI, String d)
        {
            repository.AddUser(UI);
            return RedirectToAction("ConfirmAccount", UI);
        }

        [HttpGet]
        public ViewResult Login(UserModel UI)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserModel UI, String d)
        {
            repository.AddUser(UI);
            return RedirectToAction("ConfirmAccount", UI);
        }
    }
}