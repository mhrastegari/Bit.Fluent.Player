namespace Bit.Fluent.Player.Client.Core.Shared;

public partial class MainLayout
{
    private bool _isMenuOpen;

    private void ToggleMenuHandler()
    {
        _isMenuOpen = !_isMenuOpen;
    }
}
