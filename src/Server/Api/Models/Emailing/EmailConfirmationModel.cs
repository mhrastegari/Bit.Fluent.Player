using Bit.Fluent.Player.Server.Api.Resources;

namespace Bit.Fluent.Player.Server.Api.Models.Emailing;

public class EmailConfirmationModel
{
    public string? ConfirmationLink { get; set; }

    public Uri? HostUri { get; set; }

    public IStringLocalizer<EmailStrings> EmailLocalizer { get; set; } = default!;
}
