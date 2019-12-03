using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class OrcamentoController : Controller
    {
           public IActionResult  CadastroEventos()
           {
              return View (new BaseViewModel()
              {
                  NomeView = "Orcamento"
              });
           }
           public IActionResult CadastrarPedido(IFormCollection form)
        { 
              ViewData["Action"] = "Orcamento";
            try{
                   Cliente cliente = new Cliente(form["nome"], form["documento"], form ["email"], form["senha"]);
                   clienteRepositorio.Inserir(cliente);
                   return View("Sucesso");

            } catch(Exception e)
            {
                return View("Erro");
            }
         
        }   
    }
}