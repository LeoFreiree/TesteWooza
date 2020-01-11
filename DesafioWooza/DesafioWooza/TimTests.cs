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
            Console.WriteLine("Menu Planos da Tim acessado com sucesso");
            Thread.Sleep(4000);
            planoceltim.validarPlanoControle3GB();
            Console.WriteLine("Método 'validarPlanoControle3GB' foi executado com sucesso.");
            planoceltim.btnContratar.Click();
            Console.WriteLine("btn contratar selecionado com sucesso");
            Thread.Sleep(4000);
        }

        

    }
}
