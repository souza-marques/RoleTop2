using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Models;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class OrcamentoController : AbstractController
    {
        OrcamentoRepository orcamentoRepository = new OrcamentoRepository();

        ClienteRepository clienteRepository = new ClienteRepository();
     
       public IActionResult Index()
       {
           OrcamentoViewModel orcamento = new OrcamentoViewModel();

            var usuarioLogado = ObterUsuarioSession();

            var clienteLogado = clienteRepository.ObterPor(usuarioLogado);
            if(clienteLogado != null)
            {
                orcamento.Cliente = clienteLogado;
            }
            orcamento.NomeView = "Orcamento";
            orcamento.UsuarioEmail = ObterUsuarioSession();
            orcamento.UsuarioNome = ObterUsuarioNomeSession();
           return View (orcamento);
        
       }
       
       
        public IActionResult Registrar(IFormCollection form)

        {
            ViewData ["Action"] = "Orcamento";
            Orcamento orcamento = new Orcamento();
            Cliente cliente = new Cliente() 
            {
              Nome = form["nome"],
              Cpf = form["documento"],
              Email = form["email"],
            };
              orcamento.Cliente = cliente;

              orcamento.Dataevento = DateTime.Now;


            if(orcamentoRepository.Inserir(orcamento)) {
                return View("Sucesso", new RespostaViewModel()
                {
                        Mensagem = "Aguarde a aprovação de seu evento...",
                        NomeView = "Sucesso",
                        UsuarioEmail = ObterUsuarioSession(),
                        UsuarioNome = ObterUsuarioNomeSession()
                       
                });   
            } else {
                return View ("Erro", new RespostaViewModel()
                {       
                    Mensagem = "Houve um erro ao procurar sua reserva. Tente novamente!",
                    NomeView = "Erro",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }
   
    }
}