using PackIt.Shared.Abstractions.Exceptions;

namespace PackIt.Domain.Exceptions;

public class EmptyPackingListNameExceptions : PackItException
{
    public EmptyPackingListNameExceptions() : base("Packing list name cannot be empty.")
    {
    }
}