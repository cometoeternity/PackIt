using PackIt.Shared.Abstractions.Exceptions;

namespace PackIt.Domain.Exceptions;

public class EmptyPackingListItemNameException : PackItException
{
    public EmptyPackingListItemNameException() : base("Packing item name cannot be empty.")
    {
    }
}