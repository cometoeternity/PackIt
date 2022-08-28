using PackIt.Domain.Entities;
using PackIt.Domain.ValueObjects;
using PackIt.Shared.Abstractions.Domain;

namespace PackIt.Domain.Events;

public record PackingItemAdding(PackingList PackingList, PackingItem PackingItem) : IDomainEvent;