using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Executable
{
    public class App
    {

        public void Run()
        {
            var driver = new ChromeDriver();
            var url = "https://www.einforma.co/informes-empresas";
            Console.WriteLine($"Scraping URL: {url}");
            driver.Navigate().GoToUrl(url);
            ProcessPage(driver);
            driver.Quit();
            Console.WriteLine("Console application finished running");
        }

        public static void ProcessPage(ChromeDriver driver)
        {
            var scrapedJobNode = driver.FindElement(By.XPath("//input[@id='search2']"));
            scrapedJobNode.SendKeys("900806774");

            driver.FindElement(By.XPath("//input[@id='boton_buscador_nacional']")).Click();

            var Ici = driver.FindElement(By.XPath("//*[contains(text(),'ICI')]//ancestor::td//following-sibling::td[1]")).Text;
            var Nit = driver.FindElement(By.XPath("//*[contains(text(),'Nit')]//ancestor::td//following-sibling::td[1]")).Text;
            var RazonSocial = driver.FindElement(By.XPath("//*[contains(text(),'Razón Social')]//ancestor::td//following-sibling::td[1]")).Text;
            var FormaJuridica = driver.FindElement(By.XPath("//*[contains(text(),'Forma Jurídica')]//ancestor::td//following-sibling::td[1]")).Text;
            var Departamento = driver.FindElement(By.XPath("//*[contains(text(),'Departamento')]//ancestor::td//following-sibling::td[1]")).Text;
            var DireccionActual = driver.FindElement(By.XPath("//*[contains(text(),'Dirección Actual')]//ancestor::td//following-sibling::td[1]")).Text;
            var Telefono = driver.FindElement(By.XPath("//*[contains(text(),'Teléfono')]//ancestor::td//following-sibling::td[1]")).Text;
            var Email = driver.FindElement(By.XPath("//*[contains(text(),'Email')]//ancestor::td//following-sibling::td[1]")).Text;
            var ActividadCIIU = driver.FindElement(By.XPath("//*[contains(text(),'Actividad CIIU')]//ancestor::td//following-sibling::td[1]")).Text;
            var FechaConstitucion = driver.FindElement(By.XPath("//*[contains(text(),'Fecha Constitución')]//ancestor::td//following-sibling::td[1]")).Text;
            var MatriculaMercantil = driver.FindElement(By.XPath("//*[contains(text(),'Matrícula Mercantil')]//ancestor::td//following-sibling::td[1]")).Text;



            Console.WriteLine($"{Ici}");
            Console.WriteLine($"{Nit}");
            Console.WriteLine($"{RazonSocial}");
            Console.WriteLine($"{FormaJuridica}");
            Console.WriteLine($"{Departamento}");
            Console.WriteLine($"{DireccionActual}");
            Console.WriteLine($"{Telefono}");
            Console.WriteLine($"{Email}");
            Console.WriteLine($"{ActividadCIIU}");
            Console.WriteLine($"{FechaConstitucion}");
            Console.WriteLine($"{MatriculaMercantil}");
        }
    }
}
