namespace HM_SpotifyAPI_ExamenP3.Views;

public partial class MenuPrincipal : ContentPage
{
	public MenuPrincipal()
	{
		InitializeComponent();
	}

    private void irBuscar_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(BuscarSpotify));
    }

    private void irSQL_Clicked(object sender, EventArgs e)
    {

    }
}