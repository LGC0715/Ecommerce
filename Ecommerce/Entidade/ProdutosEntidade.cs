using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Entidade
{
    public class ProdutosEntidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public float Preco { get; set; }
        public int Estoque { get; set; }

        public object[] Linha()
        {
            return new object[] { Id, Nome, Descricao, Preco, Estoque };
        }
    }
}