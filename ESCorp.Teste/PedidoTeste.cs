using System;
using ESCorp.Negocio;
using ESCorp.Negocio.Enumeradores;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ESCorp.Teste
{
    [TestClass]
    public class PedidoTeste
    {

        [TestMethod]
        public void Validar_QuandoDataNaoInformada_DeveRetornarFalso()
        {
            //Arrange
            var pedido = new Pedido();

            var esperado = false;

            //Act
            var atual = pedido.Validar();

            //Assert
            Assert.AreEqual(esperado, atual);
        }

        [TestMethod]
        public void Entregar_QuandoChamarEntregar_DeveAtribuirComoEntregue()
        {
            //Arrange
            var pedido = new Pedido(5, DateTime.Now);

            //Act
            pedido.Entregar();

            //Assert
            Assert.IsTrue(pedido.Entregue);
            Assert.IsTrue(pedido.DataEntrega.HasValue);
        }

        [TestMethod]
        public void Cancelar_QuandoChamarCancelar_DeveAtribuirComoCancelado()
        {
            //Arrange
            var pedido = new Pedido(5, DateTime.Now);

            //Act
            pedido.Cancelar();

            //Assert
            Assert.IsTrue(pedido.Cancelado);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Cancelar_QuandoEntregue_NaoDeveAtribuirComoCancelado()
        {
            //Arrange
            var pedido = new Pedido(5, DateTime.Now);
            pedido.Entregar();
            Console.WriteLine(pedido.ToString());

            //Act
            pedido.Cancelar();

            //Assert
            Assert.IsFalse(pedido.Cancelado);
        }

        [TestMethod]
        public void CalcularValorTotal_QuandoChamarMétodo_DeveRetornarValorPedido()
        {
            //Arrange
            var pedido = new Pedido(1, DateTime.Now);
            pedido.Itens.Add(new ItemPedido(1,1,1,50));
            pedido.Itens.Add(new ItemPedido(2, 2, 2, 25));

            var esperado = 100;

            //Act
            var atual = pedido.CalcularValorTotal();

            //Assert
            Assert.AreEqual(esperado, atual);
        }

        [TestMethod]
        public void CalcularValorTotal_QuandoPedidoCallCenter_DeveRetornarValorPedidoComCincoPorCentoDesconto()
        {
            //Arrange
            var pedido = new Pedido(1, DateTime.Now);
            pedido.TipoPedido = TipoPedido.CallCenter;
            pedido.Itens.Add(new ItemPedido(1, 1, 1, 50));
            pedido.Itens.Add(new ItemPedido(2, 2, 2, 25));

            var esperado = 95;

            //Act
            var atual = pedido.CalcularValorTotal();

            //Assert
            Assert.AreEqual(esperado, atual);
        }

        [TestMethod]
        public void CalcularValorTotal_QuandoPedidoOnLine_DeveRetornarValorPedidoComQuinzePorCentoDesconto()
        {
            //Arrange
            var pedido = new Pedido(1, DateTime.Now);
            pedido.TipoPedido = TipoPedido.OnLine;
            pedido.Itens.Add(new ItemPedido(1, 1, 1, 50));
            pedido.Itens.Add(new ItemPedido(2, 2, 2, 25));

            var esperado = 85;

            //Act
            var atual = pedido.CalcularValorTotal();

            //Assert
            Assert.AreEqual(esperado, atual);
        }

        [TestMethod]
        public void CalcularValorTotal_QuandoPedidoBalcao_DeveRetornarValorPedidoComVintePorCentoDesconto()
        {
            //Arrange
            var pedido = new Pedido(1, DateTime.Now);
            pedido.TipoPedido = TipoPedido.Balcao;
            pedido.Itens.Add(new ItemPedido(1, 1, 1, 50));
            pedido.Itens.Add(new ItemPedido(2, 2, 2, 25));

            var esperado = 80;

            //Act
            var atual = pedido.CalcularValorTotal();

            //Assert
            Assert.AreEqual(esperado, atual);
        }
    }
}
