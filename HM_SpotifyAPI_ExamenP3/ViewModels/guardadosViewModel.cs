using HM_SpotifyAPI_ExamenP3.Models;
using HM_SpotifyAPI_ExamenP3.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HM_SpotifyAPI_ExamenP3.ViewModels
{
    public class guardadosViewModel
    {
        public List<guardados> saveList { get; set; }

        public guardadosViewModel()
        {
            // Agregar dos reservas predeterminadas
            saveList = new List<guardados>();
            saveList.AddRange(App.saveRepo.GetAll());
        }

        public ICommand DeleteCommand => new Command<guardados>(async (saves) => await DeleteReserva(saves));

        private async Task DeleteReserva(guardados sav)
        {
            if (sav != null)
            {
                App.saveRepo.Delete(sav.id);
                saveList.Remove(sav);
                await Shell.Current.DisplayAlert("Éxito", "Reserva eliminada con éxito", "OK");
                await Shell.Current.GoToAsync(nameof(MenuPrincipal));

            }
        }
    }
}
