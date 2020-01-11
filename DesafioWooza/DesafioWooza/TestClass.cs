using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Firefox;
//using System.Threading;
using System;

namespace DesafioWooza
{
    [TestFixture]
    public class Tests
    {
        private IWebDriver driver;


        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }


        [Test]
        public void Test1()
        {
            PaginaPrincipal principal = new PaginaPrincipal(driver);

            principal.goPaginaPrincipal();
            principal.goMenuPlanosDeCelular_TIM();

        }


        [TearDown]
        public void TearDownTest()
        {
            driver.Close();
        }

    }
}