using Bit.Fluent.Player.Shared.Dtos.Identity;

namespace Bit.Fluent.Player.Client.Core.Services.Contracts;

public interface IAuthenticationService
{
    Task SignIn(SignInRequestDto dto);

    Task SignOut();
}
