using PackIt.Domain.ValueObjects;

namespace PackIt.Domain.Policies.Temperature;

internal sealed class HighTemperaturePolicy : IPackingItemsPolicy
{
    public bool IsApplicable(PolicyData data)
        => data.Temperature > 25d;

    public IEnumerable<PackingItem> GenerateItems(PolicyData data)
        => new List<PackingItem>
        {
            new PackingItem("Hat", 1),
            new PackingItem("Sunglasses", 1),
            new PackingItem("Cream with UV filter", 1)
        };
}