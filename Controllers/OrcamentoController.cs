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
     
          [HttpGet]
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
       
       [HttpPost]
        public IActionResult Registrar(IFormCollection form)

        {
            ViewData ["Action"] = "Orcamento";
            Orcamento orcamento = new Orcamento();
            Cliente cliente = new Cliente() 
            {
              Nome = form["nome"],
              Cpf = form["cpf"],
              Email = form["email"],
            };
            
              orcamento.Cliente = cliente;
              orcamento.Cliente.Nome = form["nome-pessoa"];
              orcamento.Cliente.Cpf = form["cpf-pessoa"];
              orcamento.Nome_evento = form["nome-evento"];
              orcamento.Tipo_evento = form["tipo-evento"];
              orcamento.Quantidade = form["quantidade"];
              orcamento.Dataevento = DateTime.Parse(form["dataevento"]);
              orcamento.Cliente.Email = form["email"];
              orcamento.Observacoes = form["observacoes"];
              orcamento.Servicos = form["servicos"];
              orcamento.Forma_Pagamento = form["forma-pagamento"];
              



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