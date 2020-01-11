using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace DesafioWooza
{
    class PlanosCelular_Tim : WebDriver
    {
        //Mapeamento da página "https://www.celulardireto.com.br/planos-celular/tim/" obtida através do menu "Planos de celular da "PaginaPrincipal"

        public IWebElement btnContratar => driver.FindElement(By.XPath("/html/body/div[4]/wza-vrj-mobile-plan-comparison/main/div/section/div[1]/mpc-card-plan/section/div[3]/div/button"));


        //Métodos da página

        public void validarPlanoControle3GB()
        {
            try
            {
                Assert.Multiple(() =>
                {

                    Assert.AreEqual("Controle", driver.FindElement(By.CssSelector("h4.title.ng-binding")).Text);
                    Assert.AreEqual("3GB", driver.FindElement(By.CssSelector("span.data.ng-binding")).Text);
                    Assert.AreEqual("Sem permanência mínima", driver.FindElement(By.CssSelector("span.label.-fidelity.ng-binding")).Text);
                    Assert.AreEqual("49", driver.FindElement(By.CssSelector("strong.real.ng-binding")).Text);                    

                });
            }
            catch (Exception)
            {
                Console.WriteLine("Método 'validarPlanoControle3GB' não foi executado com sucesso." +
                    " Não foram encontrados todos os elementoss do Plano 3GB");
                throw;
            }
            

        }

    }


}

