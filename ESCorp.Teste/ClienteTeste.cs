using System;
using ESCorp.Negocio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ESCorp.Teste
{
    [TestClass]
    public class ClienteTeste
    {
        //[Medodo]_[Condicao]_[ResultadoEsperado]

        [TestMethod]
        public void NomeCompleto_QuandoObterNomeCompleto_DeveRetornarNomeSobrenome()
        {
            //Arrange
            Cliente cliente = new Cliente
            {
                Nome = "Everton",
                Sobrenome = "Batista"
            };

            string resultadoEsperado = "Batista , Everton";
            
            //Act
            string resultadoAtual = cliente.NomeCompleto;

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoAtual);

        }

        [TestMethod]
        public void NomeCompleto_QuandoPrimeiroNomeVazio_DeveRetornarSomenteSobrenome()
        {
            //Arrange
            Cliente cliente = new Cliente
            {
                Nome = "", 
                Sobrenome = "Batista" // acessando o set da propriedade
            };

            var nome = cliente.Nome; // acessando o get da propriedade

            string resultadoEsperado = "Batista";
            //Act
            string resultadoAtual = cliente.NomeCompleto;

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }

        [TestMethod]
        public void NomeCompleto_QuandoSobrenomeVazio_DeveRetornarSomenteSobrenome()
        {
            //Arrange
            Cliente cliente = new Cliente
            {
                Nome = "Everton",
                Sobrenome = ""
            };

            string resultadoEsperado = "Everton";
            //Act
            string resultadoAtual = cliente.NomeCompleto;

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }
    }
}
