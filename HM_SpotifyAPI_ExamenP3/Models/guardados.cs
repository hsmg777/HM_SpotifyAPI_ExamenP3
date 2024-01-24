using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_SpotifyAPI_ExamenP3.Models
{
    [Table("cotizacion")]
    public class guardados
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; } 
        public string name { get; set; }    
        public string imagen{ get; set;}
    }
}
