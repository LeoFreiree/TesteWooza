using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DesafioWooza
{
    [TestFixture]
    public class WebDriver
    {
        public static IWebDriver driver { get; set; }


        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.celulardireto.com.br");
            
        }


        [TearDown]
        public void TearDownTest()
        {
            driver.Close();
        }

    }
}