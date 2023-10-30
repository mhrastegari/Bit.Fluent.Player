using Bit.Fluent.Player.Server.Api.Models.Identity;
using Bit.Fluent.Player.Shared.Dtos.Identity;

namespace Bit.Fluent.Player.Server.Api.Services.Contracts;

public interface IJwtService
{
    Task<SignInResponseDto> GenerateToken(User user);
}
