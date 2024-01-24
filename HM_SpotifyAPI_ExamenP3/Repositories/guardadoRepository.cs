using HM_SpotifyAPI_ExamenP3.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_SpotifyAPI_ExamenP3.Repositories
{
    public class guardadoRepository
    {
        SQLiteConnection connection;
        public string StatusMessagge { get; set; }
        public guardadoRepository()
        {
            connection =
                new SQLiteConnection(Constants.DatabasePath,
                Constants.Flags);
            connection.CreateTable<guardados>();

        }
        public void Add(guardados save)
        {
            int result = 0;
            try
            {
                    result = connection.Insert(save);
                    StatusMessagge =
                        $"{result} row(s) addded";

            }
            catch (Exception ex)
            {
                StatusMessagge = $"ERROR {ex.Message}";

            }

        }
        public List<guardados> GetAll()
        {
            try
            {
                return connection.Table<guardados>().ToList();
            }
            catch (Exception ex)
            {
                StatusMessagge = $"ERROR {ex.Message}";
            }
            return null;
        }
        public guardados Get(int id)
        {
            try
            {
                return connection.Table<guardados>().FirstOrDefault(x => x.id == id);
            }
            catch (Exception ex)
            {
                StatusMessagge = $"ERROR {ex.Message}";
            }
            return null;
        }

        public void Delete(int saveId)
        {
            try
            {
                var save =
                    Get(saveId);
                connection.Delete(save);
            }
            catch (Exception ex)
            {
                StatusMessagge = $"ERROR {ex.Message}";
            }
        }
    }
}
