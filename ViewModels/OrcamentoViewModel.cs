using RoleTopMVC.Models;

namespace RoleTopMVC.ViewModels
{
    public class OrcamentoViewModel : BaseViewModel
    {
        public Cliente Cliente {get;set;}

        public OrcamentoViewModel()
        {
            this.Cliente = new Cliente();
        }
        
    }
}