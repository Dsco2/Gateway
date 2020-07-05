using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using PhantomBot.Models;

namespace PhantomBot
{
    public class Phantom : IPhantom
    {
        public DataModel GetInfo(string value, ScraperInfo model)
        {
            var driver = new ChromeDriver("C:\\Users\\Ing-c\\source\\repos\\Gateway\\PhantomBot\\bin\\Debug\\netcoreapp3.1");
            driver.Navigate().GoToUrl(model.Url);
            var pageInfo = ProcessPage(driver, value, model);
            driver.Quit();
            return pageInfo;
        }

        public static DataModel ProcessPage(ChromeDriver driver, string value, ScraperInfo model)
        {
            Thread.Sleep(1000);
            var scrapedJobNode = driver.FindElement(By.XPath(model.Search));
            scrapedJobNode.SendKeys(value);

            if (model.Dropdown)
            {
                var selectElement = new SelectElement(driver.FindElement(By.XPath("//select[@id='ddlTipId']")));
                selectElement.SelectByText("Nit");
            }

            driver.FindElement(By.XPath(model.Submit)).Click();

            var eInforma = new DataModel
            {
                ICI = model.ICI != null? driver.FindElement(By.XPath(model.ICI))?.Text : string.Empty,
                Nit =  model.Nit != null? driver.FindElement(By.XPath(model.Nit))?.Text : string.Empty,
                RazonSocial =  model.RazonSocial != null? driver.FindElement(By.XPath(model.RazonSocial))?.Text : string.Empty,
                FormaJuridica =  model.FormaJuridica != null? driver.FindElement(By.XPath(model.FormaJuridica))?.Text : string.Empty,
                Departamento =  model.Departamento != null? driver.FindElement(By.XPath(model.Departamento))?.Text : string.Empty,
                DireccionActual =  model.DireccionActual != null? driver.FindElement(By.XPath(model.DireccionActual))?.Text : string.Empty,
                Telefono =  model.Telefono != null? driver.FindElement(By.XPath(model.Telefono))?.Text : string.Empty,
                Email =  model.Email != null? driver.FindElement(By.XPath(model.Email))?.Text : string.Empty,
                ActividadCIIU =  model.ActividadCIIU != null? driver.FindElement(By.XPath(model.ActividadCIIU))?.Text : string.Empty,
                FechaConstitucion =  model.FechaConstitucion != null? driver.FindElement(By.XPath(model.FechaConstitucion))?.Text : string.Empty,
                MatriculaMercantil =  model.MatriculaMercantil != null? driver.FindElement(By.XPath(model.MatriculaMercantil))?.Text : string.Empty,
                FechaActual =  model.FechaActual != null? driver.FindElement(By.XPath(model.FechaActual))?.Text : string.Empty,
                Estado =  model.Estado != null? driver.FindElement(By.XPath(model.Estado))?.Text : string.Empty,
            };

            return eInforma;
        }
    }
}
