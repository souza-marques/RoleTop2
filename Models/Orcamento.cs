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
        public  DateTime Dataevento {get;set;}
        public int Quantidade {get;set;}
        public string Observacoes {get;set;}


        public Orcamento(string nome_evento,DateTime data_evento,int quantidade, string observacoes)
        {
            this.Cliente = new Cliente();
            this.Id = 0;
            this.Status = (uint) StatusOrcamento.PENDENTE;
            this.Nome_evento = nome_evento;
            this.Dataevento = data_evento;
            this.Quantidade = quantidade;
            this.Observacoes = observacoes;
        }
    }
}