using IWS.CoreBusiness;
using IWS.UseCase.PluginInterfaces;

namespace IWS.Plugin.InMemory;

public class Repository : IRepository
{
    private List<Item> _items = new();

    public Repository()
    {
        _items = new List<Item>()
        {
            new()
            {
                ItemId = Guid.NewGuid(), Name = "Hammer", Description = "Steel Hammer", Price = 30M, Quantity = 120
            },
            new()
            {
                ItemId = Guid.NewGuid(), Name = "Nail", Description = "Steel Nail", Price = 0.5M, Quantity = 50
            },
            new()
            {
                ItemId = Guid.NewGuid(), Name = "Wrench", Description = "Mechanical wrench", Price = 60M, Quantity = 40
            },
        };
    }
    public async Task<IEnumerable<Item>> GetItemsByNameAsync(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return await Task.FromResult(_items);
        }

        return _items.Where(i => i.Name.Contains(name, StringComparison.OrdinalIgnoreCase));
    }
}