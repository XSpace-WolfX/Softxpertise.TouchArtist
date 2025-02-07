using Microsoft.AspNetCore.Components;

namespace TouchArtist.Layout
{
    public class NavMenuBase : ComponentBase
    {
        private bool collapseNavMenu = true;

        public string? NavMenuCssClass => collapseNavMenu ? "collapse" : null;

        public void ToggleNavMenu()
        {
            collapseNavMenu = !collapseNavMenu;
        }
    }
}
