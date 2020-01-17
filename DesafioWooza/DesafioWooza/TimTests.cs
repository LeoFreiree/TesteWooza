using NUnit.Framework;
using System;


namespace DesafioWooza
{
    class TimTests : WebDriver
    {
        [Test]
        public void ValidarCaixaDePesquisa()
        {
            //PaginaPrincipal principal = new PaginaPrincipal();
            
            PaginaPrincipal.cxPesquisa.Click();
            PaginaPrincipal.cxPesquisa.SendKeys("TIM");
            PaginaPrincipal.btnPesquisar.Click();
            Assert.AreEqual("TIM", PaginaPrincipal.msgPesquisa.Text);
            Console.WriteLine("Caso 'validarCaixaDePesquisa' Finalizado com sucesso");

        }

        [Test]
        public void ValidarPaginaTim()
        {
            String valoresperado = "TIM";
            Operadoras_Tim paginatim = new Operadoras_Tim();

            PaginaPrincipal.goMenuOperadoras();
            PaginaPrincipal.menuOperadoras_btnTim.Click();
            paginatim.validarPaginaTim(titulo: valoresperado);
            Console.WriteLine("Caso 'validarPaginaTim' Finalizado com sucesso.");
        }        

    }
}
