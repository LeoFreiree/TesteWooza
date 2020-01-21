using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Text.RegularExpressions;
using System;
using NUnit.Framework;

namespace DesafioWooza
{
    class PaginaPrincipal : WebDriver
    {
        //Mapeamento da página "https://www.celulardireto.com.br" obtida atraves do "WebDriver"

        public static IWebElement cxPesquisa => driver.FindElement(By.Name("phrase"));
        public static IWebElement btnPesquisar => driver.FindElement(By.CssSelector("svg"));
        public static IWebElement msgPesquisa_Completa => driver.FindElement(By.CssSelector("h2"));
        public static IWebElement msgPesquisa_Final => driver.FindElement(By.CssSelector("strong"));
        public static IWebElement menuOperadoras => driver.FindElement(By.XPath("(//a[contains(text(),'Operadoras')])[2]"));
        public static IWebElement menuOperadoras_btnTim => driver.FindElement(By.XPath("(//a[contains(text(),'TIM')])[4]"));

        //Métodos da página 

        public static void GoMenuOperadoras()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(menuOperadoras_btnTim).Perform();

        }

        private static string RetirarNumerosResultadoPesquisa()
        {
            return Regex.Replace(msgPesquisa_Completa.Text, @"[\d-]", string.Empty); // Retira todos os numeros do texto            
        }

        public static void ValidarResultadoPesquisa(string valoresperado)
        {
            Assert.AreEqual(RetirarNumerosResultadoPesquisa(), "Encontramos  resultados para: " + valoresperado);
        }
    }
}

