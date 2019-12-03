using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class GaleriaController : Controller
    {
        public IActionResult Fotos()
        {
            return View (new BaseViewModel()
            {
                NomeView = "Galeria"
            });
        }
        
    }
}