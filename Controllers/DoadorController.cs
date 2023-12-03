using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using projeto_ong.Models;

namespace projeto_ong.Controllers;

public class DoadorController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult CriarDoador()
    {
        return View();
    }
    
    public IActionResult EditarDoador()
    {
        return View();
    }

    public IActionResult DeleteDoador()
    {
        return View();
    }

    public IActionResult DeleteConfirmar()
    {
        return View();
    }
}
