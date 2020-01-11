using OpenQA.Selenium;

namespace DesafioWooza
{
    class PlanosCelular_Tim : WebDriver
    {

        public IWebElement btnContratar => driver.FindElement(By.XPath("/html/body/div[4]/wza-vrj-mobile-plan-comparison/main/div/section/div[1]/mpc-card-plan/section/div[3]/div/button"));


    }
}
