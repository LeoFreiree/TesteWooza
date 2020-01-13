using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;


namespace DesafioWooza
{
    class PaginaPrincipal : WebDriver
    {
        //Mapeamento da página "https://www.celulardireto.com.br" obtida atraves do "WebDriver"

        public IWebElement cxPesquisa => driver.FindElement(By.Name("phrase"));
        public IWebElement btnPesquisar => driver.FindElement(By.CssSelector("svg"));
        public IWebElement msgPesquisa => driver.FindElement(By.CssSelector("strong"));
        public IWebElement menuOperadoras => driver.FindElement(By.XPath("(//a[contains(text(),'Operadoras')])[2]"));
        public IWebElement menuOperadoras_btnTim => driver.FindElement(By.XPath("(//a[contains(text(),'TIM')])[4]"));

        //Métodos da página 

        public void goMenuOperadoras()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(menuOperadoras_btnTim).Perform();

        }

    }
}

