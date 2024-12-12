using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSQLMusicApp
{
    internal class Album
    {
        public int ID { get; set; }
        public String AlbumName { get; set; }
        public String ArtistName { get; set; }
        public int year { get; set; }
        public string ImageURL { get; set; }
        public string Description { get; set; }

        //later make a list of tracks

        public List<Track> Tracks { get; set; }


    }
}
