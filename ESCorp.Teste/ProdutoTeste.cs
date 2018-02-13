using System;
using System.Text;
using System.Collections.Generic;
using ESCorp.Negocio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ESCorp.Teste
{

    [TestClass]
    public class ProdutoTeste
    {
        [TestMethod]
        public void Validar_QuandoObjetoValido_DeveRetornarVerdadeiro()
        {
            //Arrange
            var produto = new Produto
            {
                Nome = "PS4",
                Preco = 1000                
            };

            var esperado = true;

            //Act
            var atual = produto.Validar();

            //Assert
            Assert.AreEqual(esperado, atual);
        }
        

        [TestMethod]
        public void Validar_QuandoNomeVazio_DeveRetornarFalso()
        {
            //Arrange
            var produto = new Produto
            {
                Nome = "",
                Preco = 1000
            };

            var esperado = false;

            //Act
            var atual = produto.Validar();

            //Assert
            Assert.AreEqual(esperado, atual);
        }

        [TestMethod]
        public void Validar_QuandoPrecoNaoInformado_DeveRetornarFalso()
        {
            //Arrange
            var produto = new Produto
            {
                Nome = "PS4"
            };

            var esperado = false;

            //Act
            var atual = produto.Validar();

            //Assert
            Assert.AreEqual(esperado, atual);
        }
    }
}
