namespace Bit.Fluent.Player.Client.Core.Shared;

public partial class Header
{
    [Parameter] public EventCallback OnToggleMenu { get; set; }

    [AutoInject] private NavigationManager _navManager { get; set; } = default!;
    [AutoInject] private BitThemeManager _bitThemeManager { get; set; } = default!;
    [AutoInject] private IBitDeviceCoordinator _bitDeviceCoordinator { get; set; } = default!;

    private async Task ToggleTheme()
    {
        await _bitDeviceCoordinator.SetDeviceTheme(await _bitThemeManager.ToggleDarkLightAsync() == "dark");
    }

    private async Task ToggleMenu()
    {
        await OnToggleMenu.InvokeAsync();
    }

    private async Task GoToEditProfile()
    {
        _navManager.NavigateTo("edit-profile");
    }
}
