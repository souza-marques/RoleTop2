using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class OrcamentoController : Controller
    {
        OrcamentoRepository orcamentoRepository = new OrcamentoRepository();

        ClienteRepository clienteRepository = new ClienteRepository();
     
        public IActionResult Registrar(IFormCollection form)

        {
            ViewData ["Action"] = "Orcamento";
            Orcamento orcamento = new Orcamento();
        }
   
    }
}