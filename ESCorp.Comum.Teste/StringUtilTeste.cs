using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ESCorp.Comum.Teste
{
    [TestClass]
    public class StringUtilTeste
    {
        [TestMethod]
        public void InserirEspacos_QuandoNomeSemEspaco_DeveInserirEspacos()
        {
            //Arrange
            var nome = "ConsolePlaystation4";

            var esperado = "Console Playstation 4";            

            //Act
            var atual = StringUtil.InserirEspacos(nome);

            //Assert
            Assert.AreEqual(esperado, atual);
        }

        [TestMethod]
        public void InserirEspacos_QuandoNomeJaTiverEspaco_NaoDeveInserirEspacos()
        {
            //Arrange
            var nome = "Console Playstation 4";

            var esperado = "Console Playstation 4";
            
            //Act
            var atual = StringUtil.InserirEspacos(nome);

            //Assert
            Assert.AreEqual(esperado, atual);
        }

        [TestMethod]
        public void InserirEspacos_QuandoNomeVazio_DeveRetornarVazio()
        {
            //Arrange
            var nome = "";

            var esperado = "";            

            //Act
            var atual = StringUtil.InserirEspacos(nome);

            //Assert
            Assert.AreEqual(esperado, atual);
        }
    }
}
