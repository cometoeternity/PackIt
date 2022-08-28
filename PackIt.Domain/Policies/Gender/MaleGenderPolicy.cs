using PackIt.Domain.ValueObjects;

namespace PackIt.Domain.Policies.Gender;

internal sealed class MaleGenderPolicy : IPackingItemsPolicy
{
    public bool IsApplicable(PolicyData data)
        => data.Gender is Consts.Gender.Male;

    public IEnumerable<PackingItem> GenerateItems(PolicyData data)
        => new List<PackingItem>
        {
            new PackingItem("Laptop", 1),
            new PackingItem("Beer", 2),
            new PackingItem("Book", 1)
        };
}