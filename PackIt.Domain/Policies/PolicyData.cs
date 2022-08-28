using PackIt.Domain.ValueObjects;

namespace PackIt.Domain.Policies;

public record PolicyData(TravelDays Days, Consts.Gender Gender, 
    ValueObjects.Temperature Temperature, Localization Localization);