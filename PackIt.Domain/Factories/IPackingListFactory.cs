using PackIt.Domain.Consts;
using PackIt.Domain.Entities;
using PackIt.Domain.ValueObjects;

namespace PackIt.Domain.Factories;

public interface IPackingListFactory
{
    PackingList Create(PackingListId id, PackingListName name, Localization localization);
    
    PackingList CreateWithDefaultItems(PackingListId id, PackingListName name, TravelDays days, Gender gender,
       Temperature temperature, Localization localization);
}