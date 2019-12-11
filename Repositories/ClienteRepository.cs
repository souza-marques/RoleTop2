using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories
{
    public class ClienteRepository : RepositoryBase
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
            var linhas = File.ReadAllLines(PATH);
            foreach ( var linha in linhas) { 
                if(ExtrairValorDoCampo("email", linha).Equals (email)){
                    Cliente c = new Cliente ();
                     c.TipoUsuario = uint.Parse(ExtrairValorDoCampo("tipo_usuario", linha));
                     c.Nome = ExtrairValorDoCampo ("nome", linha);
                     c.Cpf =  ExtrairValorDoCampo ("cpf", linha);
                     c.Senha = ExtrairValorDoCampo ("senha", linha);
                     c.Email = ExtrairValorDoCampo ("email", linha);
                    
                        return c;
                }
            }
            return null;
        }

        private string PrepararRegistrarCSV (Cliente cliente) {
            return $"tipo_usuario={cliente.TipoUsuario};nome={cliente.Nome};cpf={cliente.Cpf};senha={cliente.Senha};email={cliente.Email}";
        }

       


    }
}