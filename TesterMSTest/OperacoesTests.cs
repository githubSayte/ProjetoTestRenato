using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesterCore;


namespace TesterMSTest
{
    // classe de testes que você queira executar 
    [TestClass]
    public class OperacoesTests
    {
        // método de teste 

        [TestMethod]

        public void SomarDoisNumeroRetornaResultado()
        {
            //Arrange – organizar, preparar o teste 
            double primeiroNumero = 10;
            double segundoNumero = 20;
            // act – agir – execução/chamada do método 
            var resultado = Operacoes.Somar(primeiroNumero, segundoNumero);
            // Assert – comportamento esperado, comportamento obtido
            Assert.AreEqual(30, resultado);
        }

    }
}