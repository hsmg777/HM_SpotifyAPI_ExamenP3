using HM_SpotifyAPI_ExamenP3.Models;
using Newtonsoft.Json;

namespace HM_SpotifyAPI_ExamenP3.Views;

public partial class BuscarSpotify : ContentPage
{
	public BuscarSpotify()
	{
		InitializeComponent();
	}

    private async void buscar_clicked(object sender, EventArgs e)
    {
        string art = lblartista.Text;

        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri($"https://spotify23.p.rapidapi.com/search/?q={Uri.EscapeDataString(art)}&type=albums&offset=0&limit=10&numberOfTopResults=5"),
            Headers =
        {
            { "X-RapidAPI-Key", "ca2de54915msh47c6f73f1c96837p100833jsnfdecc09caff8" },
            { "X-RapidAPI-Host", "spotify23.p.rapidapi.com" },
        },
        };

        using (var response = await client.SendAsync(request))
        {
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            var spoty = JsonConvert.DeserializeObject<Rootobject>(body);
            Array array = spoty.albums.items;

            for (int i = 0; i <= array.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        lblimagen.Source = spoty.albums.items[i].data.coverArt.sources[i].url;
                        lblinfo.Text = spoty.albums.items[i].data.name;
                        break;
                    case 1:
                        lblimagen2.Source = spoty.albums.items[i].data.coverArt.sources[i].url;
                        lblinfo2.Text = spoty.albums.items[i].data.name;

                        break;
                    case 2:
                        lblimagen3.Source = spoty.albums.items[i].data.coverArt.sources[i].url;
                        lblinfo3.Text = spoty.albums.items[i].data.name;
                        break;
                }
            }



        }

        lblartista.Text = null;
    }

    private void guardar_Clicked(object sender, EventArgs e)
    {

    }
}