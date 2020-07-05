using System.Collections.Generic;
using Business.Interfaces;
using Business.Pages;
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

        public List<DataModel> GetInfo(string value)
        {
            var pagesList = new List<DataModel>();

            var eInforma = PageModel.GetEInformaModel();
            pagesList.Add(_phantom.GetInfo(value, eInforma));

            var dian = PageModel.GetDianModel();
            pagesList.Add(_phantom.GetInfo(value, dian));
            
            var rues = PageModel.GetRuesModel();
            pagesList.Add(_phantom.GetInfo(value, rues));



            return pagesList;
        }
    }
}
