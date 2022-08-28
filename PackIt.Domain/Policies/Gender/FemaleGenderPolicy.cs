using PackIt.Domain.ValueObjects;

namespace PackIt.Domain.Policies.Gender;

internal sealed class FemaleGenderPolicy : IPackingItemsPolicy
{
    public bool IsApplicable(PolicyData data)
        => data.Gender is Consts.Gender.Female;

    public IEnumerable<PackingItem> GenerateItems(PolicyData data)
        => new List<PackingItem>
        {
            new PackingItem("Lipstick", 1),
            new PackingItem("Powder", 1),
            new PackingItem("Eyeliner", 1)
        };
}