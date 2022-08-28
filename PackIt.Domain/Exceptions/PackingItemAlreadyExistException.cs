using PackIt.Shared.Abstractions.Exceptions;

namespace PackIt.Domain.Exceptions;

public class PackingItemAlreadyExistException : PackItException
{
    public PackingItemAlreadyExistException(string listName , string itemName) 
        : base($"Packing list: '{listName}' already defined item '{itemName}'.")
    {
    }
}