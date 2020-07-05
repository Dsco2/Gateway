using PhantomBot.Models;

namespace PhantomBot
{
    public interface IPhantom
    {
        EInformaModel GetInfo(string value, string url);
    }
}
