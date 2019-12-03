using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Models;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class CadastroController : AbstractController
    {
       ClienteRepository clienteRepositorio = new ClienteRepository();
        public IActionResult Index()
        {
            return View(new  BaseViewModel()
            {
                NomeView = "Cadastro",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        public IActionResult CadastrarCliente(IFormCollection form)
        { 
              ViewData["Action"] = "Cadastro";
            try{
                   Cliente cliente = new Cliente(form["nome"], form["documento"], form ["email"], form["senha"]);
                   clienteRepositorio.Inserir(cliente);
                   return View("Sucesso", new RespostaViewModel());

            } catch(Exception e)
            {
                return View("Erro", new RespostaViewModel());
            }
         
        }   
    }
}