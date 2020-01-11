using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace DesafioWooza
{
    class PaginaPrincipal : WebDriver
    {
        //Mapeamento da página "https://www.celulardireto.com.br" obtida atraves do "WebDriver"

        public IWebElement menuPlanosDeCelular => driver.FindElement(By.XPath("(//a[contains(text(),'Planos de celular')])[2]"));
        public IWebElement menuPlanosDeCelular_btnTim => driver.FindElement(By.XPath("(//a[contains(text(),'TIM')])[3]"));

        //Métodos da página 

        public void goMenuPlanosDeCelular()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(menuPlanosDeCelular).Perform();

        }

    }

}

