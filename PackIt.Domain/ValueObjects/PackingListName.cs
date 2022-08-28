using PackIt.Domain.Exceptions;

namespace PackIt.Domain.ValueObjects;

public record PackingListName
{
    public string Value { get; }

    public PackingListName(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new EmptyPackingListNameExceptions();
        }
        Value = value;
    }
    
    public static implicit operator string(PackingListName name)
        => name.Value;

    public static implicit operator PackingListName(string name)
        => new PackingListName(name);
}