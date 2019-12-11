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
                var quantidadeOrcamentos = File.ReadAllLines(PATH).Length;
                orcamento.Id = (ulong) ++quantidadeOrcamentos;
                var linha = new string[] {PrepararRegistroCSV (orcamento)};
                File.AppendAllLines(PATH, linha);

                return true;
            }



                public List<Orcamento> ObterTodosPorCliente(string email)
                {
                    var orcamentos = ObterTodos();
                    List<Orcamento> orcamentosCliente = new List<Orcamento>();

                    foreach (var orcamento in orcamentos)
                    {
                        if(orcamento.Cliente.Email.Equals(email))
                        {
                            orcamentosCliente.Add(orcamento);
                        }
                    }
                    return orcamentosCliente;
                }

          public List<Orcamento> ObterTodos()
                {
                     var linhas = File.ReadAllLines(PATH);
                     List<Orcamento> orcamentos = new List<Orcamento>();
                     foreach(var linha in linhas )
                     {
                         Orcamento orcamento = new Orcamento();
                         orcamento.Id = ulong.Parse(ExtrairValorDoCampo("id",linha));
                         orcamento.Status = uint.Parse(ExtrairValorDoCampo("status_orcamento", linha));
                         orcamento.Cliente.Nome = ExtrairValorDoCampo("cliente_nome", linha);
                         orcamento.Cliente.Cpf = ExtrairValorDoCampo("cliente_cpf",linha);
                         orcamento.Cliente.Email = ExtrairValorDoCampo("cliente_email", linha);
                        
                            
                         orcamento.Nome_evento = ExtrairValorDoCampo("nome-evento",linha);
                         orcamento.Tipo_evento = ExtrairValorDoCampo("tipo-evento",linha);
                         orcamento.Quantidade = ExtrairValorDoCampo("quantidade", linha);
                         orcamento.Dataevento = DateTime.Parse(ExtrairValorDoCampo("dataevento",linha));
                         orcamento.Observacoes = ExtrairValorDoCampo("observacoes", linha);
                         orcamento.Servicos = ExtrairValorDoCampo("servicos", linha);
                         orcamento.Forma_Pagamento = ExtrairValorDoCampo("forma-pagamento",linha);
                        
                         
                         orcamentos.Add(orcamento);
                     }
                     return orcamentos;
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
                public bool Atualizar(ulong id,Orcamento orcamento)
            {
               var orcamentosTotais =  File.ReadAllLines(PATH);
               var orcamentoCSV = PrepararRegistroCSV(orcamento);
               var linhaOrcamento = -1; 
               var resultado = false;

               for (int i = 0; i < orcamentosTotais.Length; i++)
                {
                    var idConvertido = ulong.Parse(ExtrairValorDoCampo("id", orcamentosTotais[i]));
                    if(orcamento.Id.Equals(idConvertido)) 
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

             private string PrepararRegistroCSV(Orcamento orcamento)
            {
                Cliente cliente = orcamento.Cliente;
               
                return $" id={orcamento.Id};status_orcamento={orcamento.Status};cliente_nome={cliente.Nome};cliente_cpf={cliente.Cpf};cliente_email={cliente.Email};nome-evento={orcamento.Nome_evento};tipo-evento={orcamento.Tipo_evento};quantidade={orcamento.Quantidade};dataevento={orcamento.Dataevento};observacoes={orcamento.Observacoes};servicos={orcamento.Servicos};forma-pagamento={orcamento.Forma_Pagamento};";
            }

             


                   
    }
}