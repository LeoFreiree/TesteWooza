using NUnit.Framework;
using System;


namespace DesafioWooza
{
    class TimTests : WebDriver
    {
        private const string _valoresperado = "TIM";

        [Test]
        public void ValidarCaixaDePesquisa()
        {                        
            PaginaPrincipal.cxPesquisa.Click();
            PaginaPrincipal.cxPesquisa.SendKeys(_valoresperado);
            PaginaPrincipal.btnPesquisar.Click();
            Assert.AreEqual(PaginaPrincipal.RetirarNumerosResultadoPesquisa(), "Encontramos  resultados para: " + _valoresperado); //Realizando a validação da mensagem sem o numero de resultados
            Console.WriteLine("Caso 'validarCaixaDePesquisa' Finalizado com sucesso");
        }

        [Test]
        public void ValidarPaginaTim()
        {
            Operadoras_Tim paginatim = new Operadoras_Tim();
            
            PaginaPrincipal.GoMenuOperadoras();
            PaginaPrincipal.menuOperadoras_btnTim.Click();
            paginatim.ValidarPaginaTim(titulo: _valoresperado);
            Console.WriteLine("Caso 'validarPaginaTim' Finalizado com sucesso.");
        }        

    }
}
