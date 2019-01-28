using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace bit285_assignment1_naps.Controllers
{
    public class NapsController : Controller
    {
        [HttpGet]
        public ViewResult AccountInfo()
        {
            return View ("AccountInfo");
        }

        
    }
}