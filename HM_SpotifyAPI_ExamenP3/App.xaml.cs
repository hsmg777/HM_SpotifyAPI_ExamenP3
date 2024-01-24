using HM_SpotifyAPI_ExamenP3.Repositories;

namespace HM_SpotifyAPI_ExamenP3;

public partial class App : Application
{
    public static guardadoRepository saveRepo { get; private set; }
    public App(guardadoRepository repo)
	{
		InitializeComponent();
		saveRepo = repo;

		MainPage = new AppShell();
	}
}
