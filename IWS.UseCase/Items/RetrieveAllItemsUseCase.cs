using IWS.CoreBusiness;
using IWS.UseCase.PluginInterfaces;

namespace IWS.UseCase.Items;

public class RetrieveAllItemsUseCase : IRetrieveAllItemsUseCase
{
    private readonly IRepository _repository;

    public RetrieveAllItemsUseCase(IRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Item>> ExecuteAsync(string name="")
    {
        return await _repository.GetItemsByNameAsync(name);
    }
}