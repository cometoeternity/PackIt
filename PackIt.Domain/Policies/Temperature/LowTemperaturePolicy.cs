using PackIt.Domain.ValueObjects;

namespace PackIt.Domain.Policies.Temperature;

internal sealed class LowTemperaturePolicy : IPackingItemsPolicy
{
    public bool IsApplicable(PolicyData data)
        => data.Temperature < 10d;

    public IEnumerable<PackingItem> GenerateItems(PolicyData data)
        => new List<PackingItem>
        {
            new PackingItem("Winter hat", 1),
            new PackingItem("Scarf", 1),
            new PackingItem("Gloves", 1),
            new PackingItem("Hoodie", 1),
            new PackingItem("Warm jacket", 1)
        };
}