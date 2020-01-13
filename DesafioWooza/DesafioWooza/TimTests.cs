using NUnit.Framework;
using System;


namespace DesafioWooza
{
    class TimTests : WebDriver
    {
        [Test]
        public void ValidarCaixaDePesquisa()
        {
            PaginaPrincipal principal = new PaginaPrincipal();

            principal.cxPesquisa.Click();
            principal.cxPesquisa.SendKeys("TIM");
            principal.btnPesquisar.Click();
            Assert.AreEqual("TIM", principal.msgPesquisa.Text);
            Console.WriteLine("Caso 'validarCaixaDePesquisa' Finalizado com sucesso");

        }

        [Test]
        public void ValidarPaginaTim()
        {
            String valoresperado = "TIM";
            PaginaPrincipal principal = new PaginaPrincipal();
            Operadoras_Tim paginatim = new Operadoras_Tim();

            principal.goMenuOperadoras();
            principal.menuOperadoras_btnTim.Click();
            paginatim.validarPaginaTim(titulo: valoresperado);
            Console.WriteLine("Caso 'validarPaginaTim' Finalizado com sucesso.");
        }        

    }
}
