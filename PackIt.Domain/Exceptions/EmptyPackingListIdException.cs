using PackIt.Shared.Abstractions.Exceptions;

namespace PackIt.Domain.Exceptions;

public class EmptyPackingListIdException : PackItException
{
    public EmptyPackingListIdException() : base("Packing list ID cannot be empty.")
    {
    }
}