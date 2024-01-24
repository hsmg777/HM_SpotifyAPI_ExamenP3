using HM_SpotifyAPI_ExamenP3.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_SpotifyAPI_ExamenP3.ViewModels
{
    public class SpotyViewModel
    {
        public async Task LoadReservas(string art) {
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
                


            }

        }
    }

     
        
}
