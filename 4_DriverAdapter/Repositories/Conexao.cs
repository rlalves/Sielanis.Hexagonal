using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class Conexao
    {
        private const string StringDeConexao = "server=localhost;uid=root;pwd=root;database=Sielanis;";
        private MySqlConnection conexao;

        public Conexao()
        {
            conexao = new MySqlConnection();
        }

        public void Abrir()
        {
            try
            {
                conexao = new MySqlConnection(StringDeConexao);
                conexao.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de conexão: " + ex.Message);
            }
        }

        public void Fechar()
        {
            conexao.Close();
        }

        public MySqlConnection ObtemConexao() => conexao;
    }
}
