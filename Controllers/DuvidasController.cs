using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class DuvidasController : AbstractController
    {
        [HttpGet]
        public IActionResult DuvidasFrequentes()
        {
            return View (new BaseViewModel()
            {
                NomeView = "Duvidas",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
    }
}