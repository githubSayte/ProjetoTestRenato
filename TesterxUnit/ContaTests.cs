
using System;
using Tester.Core;
using TesterCore;
using Xunit;

namespace Tester.XUnit
{
    public class ContaTests
    {
        // https://docs.microsoft.com/pt-br/visualstudio/test/walkthrough-creating-and-running-unit-tests-for-managed-code?view=vs-2019 
        // https://learn.microsoft.com/pt-br/visualstudio/test/walkthrough-creating-and-running-unit-tests-for-managed-code?view=vs-2019

        [Fact]
        public void Deposito_ComValor_AtualizaSaldo()
        {
            // Arrange 
            double saldoInicial = 20; // saldo de início da conta  
            double valorDepositado = 4.55;  // valor a ser depositado
            double valorEsperado = 24.55;  // valor final esperado de início + depósito = Valor atualizado
            var conta = new Conta(saldoInicial); // cria uma nova conta com  o valor inicial 
           
            // Act 
            conta.Depositar(valorDepositado); // deposita um valor                                        

            // Assert 
            double valorAtualizado = conta.Saldo; // conta com valor atualizado  
   
            Assert.Equal(valorEsperado, valorAtualizado);  // valorEsperado é de 24.55. soma do saldo inicial + valor depositado
        }

        [Fact]
        public void Deposito_ComValorInvalido_RetornaErro()
        {
            // Arrange 
            double saldoInicial = 20; // saldo de início da conta  
            double valorDepositado = -8; // valor invalido a ser  depositado
            var conta = new Conta(saldoInicial); // cria uma nova conta com  o valor inicial 
               
            Assert.Throws<ArgumentOutOfRangeException>(() => conta.Depositar(valorDepositado)); // espera-se que ao depositar um valor invalido, retorne um erro
        }
    }
}
