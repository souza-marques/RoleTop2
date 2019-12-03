using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories
{
    public class ClienteRepository
    {
        private const string PATH = "Database/Cliente.csv";

          public ClienteRepository () //construtor que verifica a existencia do arquivo na database
        {
            if (!File.Exists (PATH)) {
                File.Create (PATH).Close ();
            }
        }

        public bool Inserir (Cliente cliente) {
            var linha = new string[] { PrepararRegistrarCSV (cliente) };
            File.AppendAllLines (PATH, linha);

            return true;
        }

        public Cliente ObterPor (string email) {
            var linhas = File.ReadLines (PATH);
            foreach ( var linha in linhas) { 
                if(ExtrairValorDoCampo("email", linha).Equals (email)){
                    Cliente c = new Cliente ();
                     c.Nome = ExtrairValorDoCampo ("nomeCompleto", linha);
                     c.Cpf =  ExtrairValorDoCampo ("documento", linha);
                     c.Senha = ExtrairValorDoCampo ("senha", linha);
                     c.Email = ExtrairValorDoCampo ("email", linha);
                    
                        return c;
                }
            }
            return null;
        }

        private string PrepararRegistrarCSV (Cliente cliente) {
            return $"nome = {cliente.Nome};documento={cliente.Cpf};senha={cliente.Senha};email{cliente.Email}";
        }

        public string ExtrairValorDoCampo(string nomeCampo, string linha) {
            var chave = nomeCampo;
            var indiceChave = linha.IndexOf (chave);
            var indiceTerminal = linha.IndexOf(";", indiceChave);
            var valor = "";
           
             if (indiceTerminal != -1) {
                valor = linha.Substring (indiceChave, indiceTerminal - indiceChave);
            } else {
                valor = linha.Substring (indiceChave);
            }
            System.Console.WriteLine ($"Campo {nomeCampo} tem valor {valor}");
            return valor.Replace (nomeCampo + "=", "");
        }


    }
}