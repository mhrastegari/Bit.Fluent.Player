namespace Bit.Fluent.Player.Client.Core.Shared;

public partial class NavMenu
{
    private List<BitNavItem> _navItems = new();

    [Parameter] public bool IsMenuOpen { get; set; }

    [Parameter] public EventCallback<bool> IsMenuOpenChanged { get; set; }

    protected override async Task OnInitAsync()
    {
        _navItems = new()
        {
            new BitNavItem
            {
                Text = "Home",
                IconName = BitIconName.Home,
                Url = "/",
            },
            new BitNavItem
            {
                Text = "Search",
                IconName = BitIconName.Search,
                Url = "/search",
            },
            new BitNavItem
            {
                Text = "Your library",
                IconName = BitIconName.Library,
                Url = "/library",
            }
        };
    }

    private async Task CloseMenu()
    {
        IsMenuOpen = false;
        await IsMenuOpenChanged.InvokeAsync(false);
    }

    async void CreateNewPlaylist()
    {
        try
        {
            await NewPlaylistModal.Show("", "Add to new playlist");
        }
        catch (Exception exp)
        {
        }
    }
}
