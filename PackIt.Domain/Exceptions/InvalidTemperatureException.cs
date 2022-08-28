using PackIt.Shared.Abstractions.Exceptions;

namespace PackIt.Domain.Exceptions;

public class InvalidTemperatureException : PackItException
{
    public double Value { get; }

    public InvalidTemperatureException(double value) : base($"Value '{value}' is invalid temperature.")
        => Value = value;

}