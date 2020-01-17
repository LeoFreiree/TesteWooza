using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;


namespace DesafioWooza
{
    class PaginaPrincipal : WebDriver
    {
        //Mapeamento da página "https://www.celulardireto.com.br" obtida atraves do "WebDriver"

        public static IWebElement cxPesquisa => driver.FindElement(By.Name("phrase"));
        public static IWebElement btnPesquisar => driver.FindElement(By.CssSelector("svg"));
        public static IWebElement msgPesquisa => driver.FindElement(By.CssSelector("strong"));
        public static IWebElement menuOperadoras => driver.FindElement(By.XPath("(//a[contains(text(),'Operadoras')])[2]"));
        public static IWebElement menuOperadoras_btnTim => driver.FindElement(By.XPath("(//a[contains(text(),'TIM')])[4]"));

        //Métodos da página 

        public static void goMenuOperadoras()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(menuOperadoras_btnTim).Perform();

        }

    }
}

