using System;
using System.Collections.Generic;
using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories
{
    public class OrcamentoRepository : RepositoryBase
    {
         private  const string PATH = "Database/Orcamento.csv";

             public OrcamentoRepository()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
           
        }

         public bool Inserir(Orcamento orcamento)
            {
                var quantidadeLinhas = File.ReadAllLines(PATH).Length;
                orcamento.Id = (ulong) ++quantidadeLinhas;
                var linha = new string[] {PrepararRegistroCSV(orcamento)};
                File.AppendAllLines(PATH, linha);

                return true;
            }

          public List<Orcamento> ObterTodos()
                {
                     var linhas = File.ReadAllLines(PATH);
                     List<Orcamento> orcamentos= new List<Orcamento>();
                     foreach(var linha in linhas )
                     {
                         Orcamento orcamento = new Orcamento();
                         orcamento.Id = ulong.Parse(ExtrairValorDoCampo("id",linha));
                         orcamento.Status = uint.Parse(ExtrairValorDoCampo("status_orcamento", linha));
                         orcamento.Cliente.Nome = ExtrairValorDoCampo("cliente_nome", linha);
                         orcamento.Cliente.Cpf = ExtrairValorDoCampo("cliente_documento",linha);
                         orcamento.Cliente.Email = ExtrairValorDoCampo("cliente_email", linha);

                         orcamento.Nome_evento = ExtrairValorDoCampo("nome_evento",linha);
                         orcamento.Dataevento = DateTime.Parse(ExtrairValorDoCampo("data_evento",linha));
                         orcamento.Quantidade = int.Parse(ExtrairValorDoCampo("quantidade", linha));
                         orcamento.Observacoes = ExtrairValorDoCampo("observacoes", linha);
                        
                         
                         orcamentos.Add(orcamento);
                     }
                     return orcamentos;
                }

                public List<Orcamento> ObterTodosPorCliente(string email)
                {
                    var orcamentosTotais = ObterTodos();
                    List<Orcamento> orcamentosCliente = new List<Orcamento>();

                    foreach (var orcamento in orcamentosTotais)
                    {
                        if(orcamento.Cliente.Email.Equals(email))
                        {
                            orcamentosCliente.Add(orcamento);
                        }
                    }
                    return orcamentosCliente;
                }

                 public Orcamento ObterPor(ulong id)
            {
                var orcamentosTotais = ObterTodos();
                foreach (var orcamento in orcamentosTotais)
                {
                    if(orcamento.Id == id)
                    {
                        return orcamento;
                    }
                }
                    return null;
            }

             private string PrepararRegistroCSV(Orcamento orcamento)
            {
                Cliente cliente = orcamento.Cliente;
               
                return $" id={orcamento.Id};status_orcamento={orcamento.Status};cliente_nome={cliente.Nome};cliente_documento={cliente.Cpf};cliente_email={cliente.Email};nome_evento={orcamento.Nome_evento};data_evento={orcamento.Dataevento};quantidade={orcamento.Quantidade};observacoes={orcamento.Observacoes}";
            }

             public bool Atualizar(ulong id, Orcamento orcamento)
            {
               var orcamentosTotais =  File.ReadAllLines(PATH);
               var orcamentoCSV = PrepararRegistroCSV(orcamento);
               var linhaOrcamento = -1; // linha que serve para inicializar, começa em 0 na verdade.
               var resultado = false;

               for (int i = 0; i < orcamentosTotais.Length; i++)
                {
                    var idConvertido = ulong.Parse(ExtrairValorDoCampo("id", orcamentosTotais[i]));
                    if(orcamento.Id.Equals(idConvertido))//compara o id do pedido com o id da linha e quando for igual, ele pega a informação nova e reescreve o arquivo 
                    {
                        linhaOrcamento = i;
                        resultado = true;
                        break;
                    }
                }
                if(resultado)
                {
                    orcamentosTotais[linhaOrcamento] = orcamentoCSV;
                    File.WriteAllLines(PATH, orcamentosTotais);
                }

               return resultado;
            }



                   
    }
}