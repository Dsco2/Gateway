using Business.Interfaces;
using PhantomBot;
using PhantomBot.Models;

namespace Business.Services
{
    public class InfoService : IInfoService
    {
        private readonly IPhantom _phantom;

        public InfoService(IPhantom phantom)
        {
            _phantom = phantom;
        }

        public EInformaModel GetInfo(string value)
        {
            var url = "https://www.einforma.co/informes-empresas";
            var info =_phantom.GetInfo(value, url);
            return info;
        }
    }
}
