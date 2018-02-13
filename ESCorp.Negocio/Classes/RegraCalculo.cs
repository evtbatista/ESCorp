using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESCorp.Negocio.Enumeradores;

namespace ESCorp.Negocio.Classes
{
    public abstract class RegraCalculo
    {
        public abstract TipoPedido TipoPedido { get; }
        public abstract decimal CalcularValor(ItemPedido item);
    }

    public class RegraPadrao : RegraCalculo
    {
        public override TipoPedido TipoPedido => TipoPedido.Padrao;

        public override decimal CalcularValor(ItemPedido item)
        {
            return item.Total;
        }
    }

    public class RegraCallCenter : RegraCalculo
    {
        public override TipoPedido TipoPedido => TipoPedido.CallCenter;

        public override decimal CalcularValor(ItemPedido item)
        {
            return item.Total - (item.Total*0.05M);
        }
    }

    public class RegraOnLine : RegraCalculo
    {
        public override TipoPedido TipoPedido => TipoPedido.OnLine;

        public override decimal CalcularValor(ItemPedido item)
        {
            return item.Total - (item.Total * 0.15M);
        }
    }

    public class RegraBalcao : RegraCalculo
    {
        public override TipoPedido TipoPedido => TipoPedido.Balcao;

        public override decimal CalcularValor(ItemPedido item)
        {
            return item.Total - (item.Total * 0.20M);
        }
    }

    public class CalculadoraItemPedido
    {
        private List<RegraCalculo> _regras;

        public CalculadoraItemPedido()
        {
            _regras = new List<RegraCalculo> {new RegraPadrao(), new RegraCallCenter(), new RegraOnLine(), new RegraBalcao()};
        }

        public decimal CalcularValor(TipoPedido tipoPedido, ItemPedido item)
        {
            var regraEscolhida = _regras.Single(regra => regra.TipoPedido == tipoPedido);

            return regraEscolhida.CalcularValor(item);
        }
    }
}
