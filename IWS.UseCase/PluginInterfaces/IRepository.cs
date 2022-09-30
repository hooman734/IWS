using IWS.CoreBusiness;

namespace IWS.UseCase.PluginInterfaces;

public interface IRepository
{
    Task<IEnumerable<CoreBusiness.Item>> GetItemsByNameAsync(string name);
}