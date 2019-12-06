using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Enums;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class ClienteController : AbstractController
    {
         private ClienteRepository clienteRepository = new ClienteRepository();
         
         private OrcamentoRepository orcamentoRepository = new OrcamentoRepository();
       
        [HttpGet]
        public IActionResult Login()
         {
            return View (new BaseViewModel()
            {
                NomeView = "Login",
                UsuarioEmail = ObterUsuarioNomeSession(),
                UsuarioNome = ObterUsuarioNomeSession(),
            });

        }

        
          [HttpPost]
        public IActionResult Login(IFormCollection form)
         {
            ViewData["Action"] = "Login";
            try {
                
                System.Console.WriteLine (form["email"]);
                System.Console.WriteLine (form["senha"]);
                

                var usuario = form["email"];
                var senha = form["senha"];

                var cliente = clienteRepository.ObterPor(usuario);

                if(cliente !=null ) 
                {
                    if(cliente.Senha.Equals(senha))
                    {
                        switch (cliente.TipoUsuario)
                        {
                            case (uint) TiposUsuario.CLIENTE:
                             HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, usuario);
                             HttpContext.Session.SetString(SESSION_CLIENTE_NOME, cliente.Nome);
                             HttpContext.Session.SetString(SESSION_TIPO_USUARIO, cliente.TipoUsuario.ToString());
                             return RedirectToAction("Historico","Cliente");
                       
                          default:
                             HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, usuario);
                             HttpContext.Session.SetString(SESSION_CLIENTE_NOME, cliente.Nome);
                             HttpContext.Session.SetString(SESSION_TIPO_USUARIO, cliente.TipoUsuario.ToString());
                               return RedirectToAction("Dasboard","Administrador");
                        }
                    }
                    else
                    {
                        return View("Erro",new RespostaViewModel("Senha incorreta"));
                    }
                } 
                else 
                {
                    return View("Erro", new RespostaViewModel($"Usuário {usuario} não foi encontrado"));
                }

            } catch (Exception e) {
                System.Console.WriteLine (e.StackTrace);
                return View ("Erro");
            }

        }
    public IActionResult Historico()
        {
            var emailCliente = HttpContext.Session.GetString(SESSION_CLIENTE_EMAIL);
            var orcamentos = orcamentoRepository.ObterTodosPorCliente(emailCliente);

            return View(new HistoricoViewModel()
            {
            Orcamentos = orcamentos,
            NomeView = "Historico",
            UsuarioNome = ObterUsuarioNomeSession(),
            UsuarioEmail = ObterUsuarioSession()

            });
        }

        public IActionResult Logoff()
        {
            HttpContext.Session.Remove(SESSION_CLIENTE_EMAIL);
            HttpContext.Session.Remove(SESSION_CLIENTE_NOME);
            HttpContext.Session.Clear();
            return RedirectToAction ("Index", "Home");
        }
    }
}