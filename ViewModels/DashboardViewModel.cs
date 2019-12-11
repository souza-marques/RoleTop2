using System.Collections.Generic;
using RoleTopMVC.Models;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.ViewModels
{
    public class DashboardViewModel : BaseViewModel
    {
          public List<Orcamento> Orcamentos {get;set;}
        public uint OrcamentosAprovados {get;set;}
        public uint OrcamentosReprovados {get;set;}
        public uint OrcamentosPendentes {get;set;}

        public DashboardViewModel()
        {
            this.Orcamentos = new List<Orcamento>();
        }
    }
}