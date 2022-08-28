using PackIt.Domain.Entities;
using PackIt.Domain.ValueObjects;

namespace PackIt.Domain.Repositories;

public interface IPackingListRepository
{
    Task<PackingList> GetByIdAsync(PackingListId id);
    Task AddAsync(PackingList packingList);
    Task UpdateAsync(PackingList packingList);
    Task DeleteAsync(PackingList packingList);
}