using PackIt.Domain.ValueObjects;

namespace PackIt.Domain.Policies;

public interface IPackingItemsPolicy
{
    bool IsApplicable(PolicyData data);

    IEnumerable<PackingItem> GenerateItems(PolicyData data);
}