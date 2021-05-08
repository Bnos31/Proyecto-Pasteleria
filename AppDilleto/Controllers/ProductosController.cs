using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AppDilleto.Models;
namespace AppDilleto.Controllers
{
    public class ProductosController : Controller
    {
          public IActionResult Index()
        {
            return View();
        }
    }
}