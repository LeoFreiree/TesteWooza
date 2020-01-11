using NUnit.Framework;
using System.Threading;
using OpenQA.Selenium.Interactions;
using System;

namespace DesafioWooza
{
    class TimTests : WebDriver
    {

        [Test]

        public void acessarPlanoTimviaMenueClicaremContratar()
        {
            

            PaginaPrincipal principal = new PaginaPrincipal();
            PlanosCelular_Tim planoceltim = new PlanosCelular_Tim();

            principal.goMenuPlanosDeCelular();
            principal.menuPlanosDeCelular_btnTim.Click();
            planoceltim.btnContratar.Click();
            Console.WriteLine("Menu Planos da Tim acessado com sucesso");
            Thread.Sleep(4000);
        }

        

    }
}
