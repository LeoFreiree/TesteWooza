using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace DesafioWooza
{
    class PaginaPrincipal : WebDriver
    {

       public IWebElement menuPlanosDeCelular => driver.FindElement(By.XPath("(//a[contains(text(),'Planos de celular')])[2]"));
       public IWebElement menuPlanosDeCelular_btnTim => driver.FindElement(By.XPath("(//a[contains(text(),'TIM')])[3]"));

       public void goMenuPlanosDeCelular()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(menuPlanosDeCelular).Perform();

        }

    }

}

