using IWS.CoreBusiness;
using IWS.UseCase.PluginInterfaces;

namespace IWS.UseCase.Items;

public interface IRetrieveAllItemsUseCase
{ 
    public Task<IEnumerable<Item>> ExecuteAsync(string name = "");
}