using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesterCore;


namespace TesterMSTest
{
    // classe de testes que voc� queira executar 
    [TestClass]
    public class OperacoesTests
    {
        // m�todo de teste 

        [TestMethod]

        public void SomarDoisNumeroRetornaResultado()
        {
            //Arrange � organizar, preparar o teste 
            double primeiroNumero = 10;
            double segundoNumero = 20;
            // act � agir � execu��o/chamada do m�todo 
            var resultado = Operacoes.Somar(primeiroNumero, segundoNumero);
            // Assert � comportamento esperado, comportamento obtido
            Assert.AreEqual(30, resultado);
        }

    }
}