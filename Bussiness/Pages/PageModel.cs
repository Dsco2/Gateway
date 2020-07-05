using PhantomBot.Models;

namespace Business.Pages
{
    public class PageModel
    {
        public static ScraperInfo GetEInformaModel()
        {
            return new ScraperInfo 
            {
                ICI = "//*[contains(text(),'ICI')]//ancestor::td//following-sibling::td[1]",
                Nit = "//*[contains(text(),'Nit')]//ancestor::td//following-sibling::td[1]",
                RazonSocial = "//*[contains(text(),'Razón Social')]//ancestor::td//following-sibling::td[1]",
                FormaJuridica = "//*[contains(text(),'Forma Jurídica')]//ancestor::td//following-sibling::td[1]",
                Departamento = "//*[contains(text(),'Departamento')]//ancestor::td//following-sibling::td[1]",
                DireccionActual = "//*[contains(text(),'Dirección Actual')]//ancestor::td//following-sibling::td[1]",
                Telefono = "//*[contains(text(),'Teléfono')]//ancestor::td//following-sibling::td[1]",
                Email = "//*[contains(text(),'Email')]//ancestor::td//following-sibling::td[1]",
                ActividadCIIU = "//*[contains(text(),'Actividad CIIU')]//ancestor::td//following-sibling::td[1]",
                FechaConstitucion = "//*[contains(text(),'Fecha Constitución')]//ancestor::td//following-sibling::td[1]",
                MatriculaMercantil = "//*[contains(text(),'Matrícula Mercantil')]//ancestor::td//following-sibling::td[1]",
                Submit = "//input[@id='boton_buscador_nacional']",
                Search = "//input[@id='search2']",
                Url = "https://www.einforma.co/informes-empresas"
            };
        }

        public static ScraperInfo GetDianModel()
        {
            return new ScraperInfo
            {
                RazonSocial = "//span[@id='vistaConsultaEstadoRUT:formConsultaEstadoRUT:razonSocial']",
                Submit = "//input[@id='vistaConsultaEstadoRUT:formConsultaEstadoRUT:btnBuscar']",
                Search = "//input[@id='vistaConsultaEstadoRUT:formConsultaEstadoRUT:numNit']",
                Url = "https://muisca.dian.gov.co/WebRutMuisca/DefConsultaEstadoRUT.faces",
                FechaActual = "//table[@class='muisca_area']//td[contains(text(),'actual')]//following-sibling::*[1]",
                Estado = "//table[@class='muisca_area']//td[contains(text(),'estado')]//following-sibling::*[1]"
            };
        }

        public static ScraperInfo GetRuesModel()
        {
            return new ScraperInfo
            {
                RazonSocial = "//table[@id='dtgResultados']//tr[@class='contenidos10p']/td[3]",
                MatriculaMercantil = "//a[@id='dtgResultados_HyperLink1_0']",
                Submit = "//input[@id='btnIr']",
                Search = "//input[@id='txtNumId']",
                Url = "https://linea.ccb.org.co/ccbConsultasRUE/Consultas/RUE/consulta_empresa.aspx",
                Dropdown = true,
                DropdownSelect = "//select[@id='ddlTipId']",
                DropdownOption = "Nit",
                FormaJuridica = "//table[@id='dtgResultados']//tr[@class='contenidos10p']/td[4]",
                UltimoAñoRenovado = "//table[@id='dtgResultados']//tr[@class='contenidos10p']/td[5]",
                Estado = "//table[@id='dtgResultados']//tr[@class='contenidos10p']/td[6]"
            };
        }
    }
}
