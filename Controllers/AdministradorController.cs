using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.ViewModels;
using RoleTopMVC.Controllers;
using RoleTopMVC.Enums;
using RoleTopMVC.Repositories;


namespace RoleTop2.Controllers
{
    public class AdministradorController : AbstractController
    {
        OrcamentoRepository orcamentoRepository = new OrcamentoRepository();
        public IActionResult Dashboard () {

            var ninguemLogado = string.IsNullOrEmpty(ObterUsuarioTipoSession());

            if (!ninguemLogado && 
            (uint) TiposUsuario.ADMINISTRADOR == uint.Parse(ObterUsuarioTipoSession())) {

                var orcamentos = orcamentoRepository.ObterTodos ();
                DashboardViewModel dashboardViewModel = new DashboardViewModel ();

                foreach (var orcamento in orcamentos) {
                    switch (orcamento.Status) {
                        case (uint) StatusOrcamento.APROVADO:
                            dashboardViewModel.OrcamentosAprovados++;
                            break;
                        case (uint) StatusOrcamento.REPROVADO:
                            dashboardViewModel.OrcamentosReprovados++;
                            break;
                        default:
                            dashboardViewModel.OrcamentosPendentes++;
                            dashboardViewModel.Orcamentos.Add (orcamento);
                            break;
                    }
                }
                dashboardViewModel.NomeView = "Dashboard";
                dashboardViewModel.UsuarioEmail = ObterUsuarioSession ();

                return View (dashboardViewModel);
            } 
            else 
            {
                return View ("Erro", new RespostaViewModel(){
                    NomeView = "Dashboard",
                    Mensagem = "Você não tem permissão para acessar o Dashboard"
                });

            }
        }
    }
}