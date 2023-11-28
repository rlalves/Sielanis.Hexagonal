using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class LivrosRepository
    {
        Conexao conexao = new Conexao();

        public List<string> Obterlivros()
        {
            try
            {
                List<string?> livros = new List<string?>();

                conexao.Abrir();
                string query = "SELECT nome FROM livros";

                MySqlCommand cmd = new MySqlCommand(query, conexao.ObtemConexao());
                MySqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    livros.Add(r["nome"].ToString());
                }

                conexao.Fechar();

                return livros;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
