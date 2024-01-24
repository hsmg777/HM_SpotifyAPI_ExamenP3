using HM_SpotifyAPI_ExamenP3.ViewModels;

namespace HM_SpotifyAPI_ExamenP3.Views;

public partial class guardadosView : ContentPage
{
	public guardadosView()
	{
		InitializeComponent();
        BindingContext = new guardadosViewModel();
    }
}