using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace DesafioWooza
{
    class PaginaPrincipal
    {

        private IWebDriver driver;

        public PaginaPrincipal(IWebDriver driver)
        {

            this.driver = driver;
        }

        //Dropdown menus e itens da pagina principal
        IWebElement menuPlanosDeCelular => driver.FindElement(By.XPath("(//a[contains(text(),'Planos de celular')])[2]"));
        IWebElement menuPlanosDeCelular_Tim => driver.FindElement(By.XPath("(//a[contains(text(),'TIM')])[3]"));


        public void goPaginaPrincipal()
        {
            Console.WriteLine("Acessando a pagina principal");
            driver.Navigate().GoToUrl("https://www.celulardireto.com.br");

        }

        public void goMenuPlanosDeCelular_TIM()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(menuPlanosDeCelular).Perform();
            menuPlanosDeCelular_Tim.Click();
            Console.WriteLine("Menu Planos da Tim acessado com sucesso");
            Thread.Sleep(3000);

        }

    }

}

