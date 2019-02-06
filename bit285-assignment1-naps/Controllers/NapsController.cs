using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using A1_Mod;

namespace bit285_assignment1_naps.Controllers
{
    public class NapsController : Controller
    {
        //Account Info Entry
        [HttpGet]
        public ViewResult AccountInfo()
        {
            return View ();
        }
        
        [HttpPost]
        public IActionResult AccountInfo(UserModel UI)
        {
            return RedirectToAction("PasswordInfo", UI);
        }

        //Password Info Entry
        [HttpGet]
        public ViewResult PasswordInfo(UserModel UI)
        {
            return View();
        }

        [HttpPost]
        public IActionResult PasswordInfo(UserModel UI, String d)
        {
            return RedirectToAction("SelectPassword", UI);
        }

        //Password Generator Entry
        [HttpGet]
        public ViewResult SelectPassword(UserModel UI)
        {
            return View();
        }

        [HttpPost]
        public IActionResult SelectPassword(UserModel UI, String d)
        {
            return RedirectToAction("ConfirmAccount", UI);
        }

        //Confirmation Info Entry
        [HttpGet]
        public ViewResult ConfirmAccount(UserModel UI)
        {
            return View();
        }

        [HttpPost]
        public IActionResult ConfirmAccount(UserModel UI, String d)
        {
            return RedirectToAction("Login", UI);
        }

        //Login Entry
        [HttpGet]
        public ViewResult Login(UserModel UI)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserModel UI, String d)
        {
            return RedirectToAction("https://media.giphy.com/media/10UtqJNULHPfxe/giphy.gif");
        }
    }
}