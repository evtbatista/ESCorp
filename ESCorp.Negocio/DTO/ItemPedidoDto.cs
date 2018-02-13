using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCorp.Negocio.DTO
{
    public class ItemPedidoDto
    {
        public string NomeProduto { get; set; }
        public int Quantidade { get; set; }
        public decimal? PrecoDeCompra { get; set; }

    }
}
