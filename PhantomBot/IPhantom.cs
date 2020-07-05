using PhantomBot.Models;

namespace PhantomBot
{
    public interface IPhantom
    {
        DataModel GetInfo(string value, ScraperInfo model);
    }
}
