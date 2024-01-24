using HM_SpotifyAPI_ExamenP3.Views;

namespace HM_SpotifyAPI_ExamenP3;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(MenuPrincipal), typeof(MenuPrincipal));
        Routing.RegisterRoute(nameof(BuscarSpotify), typeof(BuscarSpotify));

    }
}
