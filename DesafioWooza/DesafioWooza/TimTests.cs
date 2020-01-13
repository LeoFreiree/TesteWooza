using NUnit.Framework;
using System.Threading;
using System;


namespace DesafioWooza
{
    class TimTests : WebDriver
    {
        [Test]
        public void validarCaixaDePesquisa()
        {
            PaginaPrincipal principal = new PaginaPrincipal();

            principal.cxPesquisa.Click();
            principal.cxPesquisa.SendKeys("Tim");
            principal.btnPesquisar.Click();
            Assert.AreEqual("Tim", principal.msgPesquisa.Text);
            Console.WriteLine("Teste Finalizado com sucesso");

        }

        [Test]
        public void validarPaginaTim()
        {
            String valoresperado = "Tim";
            PaginaPrincipal principal = new PaginaPrincipal();
            Operadoras_Tim paginatim = new Operadoras_Tim();

            principal.goMenuOperadoras();
            principal.menuOperadoras_btnTim.Click();
            paginatim.validarPaginaTim(titulo: valoresperado);
            Console.WriteLine("Teste Finalizado com sucesso.");
        }        

    }
}
