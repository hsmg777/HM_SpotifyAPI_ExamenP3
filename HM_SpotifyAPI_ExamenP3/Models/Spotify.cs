using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_SpotifyAPI_ExamenP3.Models
{


    public class Rootobject
    {
        public string query { get; set; }
        public Albums albums { get; set; }
    }

    public class Albums
    {
        public int totalCount { get; set; }
        public Item[] items { get; set; }
        public Paginginfo pagingInfo { get; set; }
    }

    public class Paginginfo
    {
        public int nextOffset { get; set; }
        public int limit { get; set; }
    }

    public class Item
    {
        public Data data { get; set; }
    }

    public class Data
    {
        public string uri { get; set; }
        public string name { get; set; }
        public Artists artists { get; set; }
        public Coverart coverArt { get; set; }
        public Date date { get; set; }
    }

    public class Artists
    {
        public Item1[] items { get; set; }
    }

    public class Item1
    {
        public string uri { get; set; }
        public Profile profile { get; set; }
    }

    public class Profile
    {
        public string name { get; set; }
    }

    public class Coverart
    {
        public Source[] sources { get; set; }
    }

    public class Source
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Date
    {
        public int year { get; set; }
    }


}
