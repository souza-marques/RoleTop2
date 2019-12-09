using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class GaleriaController : AbstractController
    {
        [HttpGet]
        public IActionResult Fotos()
        {
            return View (new BaseViewModel()
            {
                NomeView = "Galeria",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        
    }
}