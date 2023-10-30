namespace Bit.Fluent.Player.Shared.Services.Contracts;

public interface IDateTimeProvider
{
    DateTimeOffset GetCurrentDateTime();
}
