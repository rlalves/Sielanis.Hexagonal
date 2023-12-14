using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication
{
    public class LivrosApp
    {
        // ObterLivros
        public string ObterLivros()
        {
            List<string> livros = new LivrosRepository().Obterlivros();
            StringBuilder sb = new StringBuilder();

            foreach (string livro in livros)
                sb.Append(livro + ", ");

            string r = sb.ToString();
            return r.Substring(0, r.Length - 2);
        }
    }
}
