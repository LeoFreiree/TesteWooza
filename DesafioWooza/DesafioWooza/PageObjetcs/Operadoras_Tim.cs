using NUnit.Framework;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.PageObjects;

namespace DesafioWooza
{
    class Operadoras_Tim : WebDriver
    {
        //Mapeamento da página "https://www.celulardireto.com.br/tim/" obtida através do menu "Operadoras" da "PaginaPrincipal"

        private string _titulopagina => driver.FindElement(By.CssSelector("h1")).Text;       

        //Métodos da página

        public void ValidarPaginaTim(string titulo)
        {
            
            try
            {
                Assert.AreEqual(titulo, _titulopagina);
            }
            catch (Exception)
            {

                Console.WriteLine("A página acessada não corresponde 'TIM'");
                throw;
            }            
            
        }

    }


}

