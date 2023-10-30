namespace Bit.Fluent.Player.Shared.Services.Contracts;

public interface IAuthTokenProvider
{
    Task<string?> GetAccessTokenAsync();
}
