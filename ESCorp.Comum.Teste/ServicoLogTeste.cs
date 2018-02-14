using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using ESCorp.Negocio;
using ESCorp.Negocio.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ESCorp.Comum.Teste
{
    [TestClass]
    public class ServicoLogTeste
    {
        [TestMethod]
        public void EscreverArquivo_QuandoChamarMetodo_DeveEscreverArquivoLog()
        {
            //Arrange
            var itensModificados = new List<ILog>();

            var cliente = new Cliente(1, "Wayne", "bruce@batman.com");
            cliente.Nome = "Bruce";

            itensModificados.Add(cliente);

            var produto = new Produto(1, "Playstarion 4", 2000);
            produto.Descricao = "Console 500Gb - Sony";

            itensModificados.Add(produto);

            //Act
            ServicoLog.EscreverArquivo(itensModificados);

            //Assert
        }
    }
}
