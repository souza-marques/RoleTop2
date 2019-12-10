using System;
using RoleTopMVC.Enums;

namespace RoleTopMVC.Models
{
    public class Orcamento
    {
        public ulong Id {get;set;}
        public Cliente Cliente {get;set;}
        public uint Status {get;set;}
        public string Nome_evento {get;set;}
        public string Tipo_evento {get;set;}
        public string Quantidade {get;set;}
        public  DateTime Dataevento {get;set;}
        public string Observacoes {get;set;}
         public string Servicos {get;set;}
         public string Forma_Pagamento{get;set;}

        public Orcamento()
        {
            this.Cliente = new Cliente();
            this.Id = 0;
            this.Status = (uint) StatusOrcamento.PENDENTE;
        }
    }
}