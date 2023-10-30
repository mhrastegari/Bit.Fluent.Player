namespace Bit.Fluent.Player.Client.Core.Shared;

public partial class Footer
{
    [AutoInject] private NavigationManager navigationManager = default!;

    private void OnFeedBackClick()
    {
        navigationManager.NavigateTo("https://github.com/bitfoundation/bitplatform");
    }
}
