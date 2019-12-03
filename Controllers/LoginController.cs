using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class LoginController : Controller 
    {
         public IActionResult Login()
        {
            return View (new BaseViewModel()
            {
                NomeView = "Login"
            });
        }
    }
}