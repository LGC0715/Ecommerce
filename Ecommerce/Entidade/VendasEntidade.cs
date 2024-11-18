using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Entidade
{
    public class VendasEntidade
    {
        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        public float Total { get; set; }

        public object[] Linha()
        {
            return new object[] { Id, DataVenda, Total };
        }
    }
}