using System.Collections.Generic;
using PhantomBot.Models;

namespace Business.Interfaces
{
    public interface IInfoService
    {
        List<DataModel> GetInfo(string value);
    }
}
