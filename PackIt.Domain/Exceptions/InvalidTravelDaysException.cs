using PackIt.Shared.Abstractions.Exceptions;

namespace PackIt.Domain.Exceptions;

public class InvalidTravelDaysException : PackItException
{
    public ushort Days { get; }

    public InvalidTravelDaysException(ushort days) : base($"Value '{days}' is invalid travel days.")
        => Days = days;
}