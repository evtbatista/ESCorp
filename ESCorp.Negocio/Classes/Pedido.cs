using System;
using System.Collections.Generic;
using System.Net.Mail;
using ESCorp.Comum;
using ESCorp.Negocio.Classes;
using ESCorp.Negocio.Enumeradores;

namespace ESCorp.Negocio
{
    public class Pedido : EntidadeBase, ILog
    {
        public int IdPedido { get; set; }
        public int IdCliente { get; set; }
        public int IdEnderecoEntrega { get; set; }
        public DateTime? Data { get; set; }
        // Propriedades Entregue e DataEntrega definida com set privado para que não seja violado o princípio de encapsulamento,
        // criando a necessidade de chamar o método Entregar e não atribuir o valor diretamente.
        public bool Entregue { get; private set; }        
        public DateTime? DataEntrega { get; private set; }
        public bool Cancelado { get; private set; }
        public List<ItemPedido> Itens { get; set; }
        public TipoPedido TipoPedido { get; set; }
        private CalculadoraItemPedido _calculadoraItemPedido;

        public Pedido()
        {
            Itens = new List<ItemPedido>();
            _calculadoraItemPedido = new CalculadoraItemPedido();
        }

        public Pedido(int idPedido, DateTime data):this() // encadeamento de construtores
        {
            IdPedido = idPedido;
            Data = data;
        }

        // Princípio Tell Don't Ask, diga ao objeto o que fazer e não pergunte o que fazer
        public void Cancelar()
        {
            if (Entregue)
                throw new ArgumentNullException("Pedido entrege não pode ser cancelado!");
                                   
            Cancelado = true;
        }

        public decimal CalcularValorTotal()
        {
            decimal valorTotal = 0;

            foreach (var item in Itens)
            {
                valorTotal += _calculadoraItemPedido.CalcularValor(TipoPedido, item);
            }

            // Código substiuído 
            //if (TipoPedido == TipoPedido.CallCenter)            
            //    valorTotal -= (valorTotal * 0.05M);

            //if (TipoPedido == TipoPedido.OnLine)
            //    valorTotal -= (valorTotal * 0.15M); // valorTotal - (valorTotal * 0.15M);



            return valorTotal;
        }
        public void Entregar()
        {
            DataEntrega = DateTime.Now;
            Entregue = true;
        }

        public override bool Validar()
        {
            bool ehValido = !(Data == null);            

            return ehValido;
        }

        public override string ToString()
        {
            return Data + " (" + IdPedido + ")";
        }

        public string Log()
        {
            var informacao = IdPedido + ": " +                 
                 "Data: " + Data.Value.Date + " " +
                 "Status: " + EstadoEntidade;

            return informacao;
        }
    }
}