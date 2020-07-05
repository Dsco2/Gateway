﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PhantomBot.Models;

namespace PhantomBot
{
    public class Phantom : IPhantom
    {
        public EInforma GetInfo(string value)
        {
            var driver = new ChromeDriver("C:\\Users\\Ing-c\\source\\repos\\Gateway\\PhantomBot\\bin\\Debug\\netcoreapp3.1");
            var url = "https://www.einforma.co/informes-empresas";
            //Console.WriteLine($"Scraping URL: {url}");
            driver.Navigate().GoToUrl(url);
            var pageInfo = ProcessPage(driver, value);
            driver.Quit();
            //Console.WriteLine("Console application finished running");

            return pageInfo;
        }

        public static EInforma ProcessPage(ChromeDriver driver, string value)
        {
            var scrapedJobNode = driver.FindElement(By.XPath("//input[@id='search2']"));
            scrapedJobNode.SendKeys(value);

            driver.FindElement(By.XPath("//input[@id='boton_buscador_nacional']")).Click();

            var eInforma = new EInforma
            {
                ICI = driver.FindElement(By.XPath("//*[contains(text(),'ICI')]//ancestor::td//following-sibling::td[1]")).Text,
                Nit = driver.FindElement(By.XPath("//*[contains(text(),'Nit')]//ancestor::td//following-sibling::td[1]")).Text,
                RazonSocial = driver.FindElement(By.XPath("//*[contains(text(),'Razón Social')]//ancestor::td//following-sibling::td[1]")).Text,
                FormaJuridica = driver.FindElement(By.XPath("//*[contains(text(),'Forma Jurídica')]//ancestor::td//following-sibling::td[1]")).Text,
                Departamento = driver.FindElement(By.XPath("//*[contains(text(),'Departamento')]//ancestor::td//following-sibling::td[1]")).Text,
                DireccionActual = driver.FindElement(By.XPath("//*[contains(text(),'Dirección Actual')]//ancestor::td//following-sibling::td[1]")).Text,
                Telefono = driver.FindElement(By.XPath("//*[contains(text(),'Teléfono')]//ancestor::td//following-sibling::td[1]")).Text,
                Email = driver.FindElement(By.XPath("//*[contains(text(),'Email')]//ancestor::td//following-sibling::td[1]")).Text,
                ActividadCIIU = driver.FindElement(By.XPath("//*[contains(text(),'Actividad CIIU')]//ancestor::td//following-sibling::td[1]")).Text,
                FechaConstitucion = driver.FindElement(By.XPath("//*[contains(text(),'Fecha Constitución')]//ancestor::td//following-sibling::td[1]")).Text,
                MatriculaMercantil = driver.FindElement(By.XPath("//*[contains(text(),'Matrícula Mercantil')]//ancestor::td//following-sibling::td[1]")).Text
            };

            return eInforma;
        }
    }
}
