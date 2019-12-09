using System;
using RoleTopMVC.Enums;

namespace RoleTopMVC.Models
{
    public class Orcamento
    {
        public ulong Id {get;set;}
        public Cliente Cliente {get;set;}
        public uint Status {get;set;}
        public string Nome_pessoa{get;set;}
        public string Nome_evento {get;set;}
        public string Tipo_evento {get;set;}
        public uint Quantidade {get;set;}
        public  DateTime Dataevento {get;set;}
        public string Observacoes {get;set;}


        public Orcamento()
        {
            this.Cliente = new Cliente();
            this.Id = 0;
            this.Status = (uint) StatusOrcamento.PENDENTE;
        }
    }
}