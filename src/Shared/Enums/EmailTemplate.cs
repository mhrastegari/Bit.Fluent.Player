namespace Bit.Fluent.Player.Shared.Enums;

[JsonConverter(typeof(JsonStringEnumConverter<EmailTemplate>))]
public enum EmailTemplate
{
    EmailChange,
    EmailConfirmation
}
