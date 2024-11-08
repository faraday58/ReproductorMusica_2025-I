

namespace ReproductorMusica_2025_I
{
    internal class Music:ICaratula 
    {
        #region Campos
        internal string title;
        internal string artist;
        internal string album;


        internal int timeStart;
        internal int timeEnd;
        internal string pathAlbum;
        #endregion

        #region Constructor
        public Music(string Title, string Artist, string Album)
        {
            this.title = Title;
            this.artist = Artist;
            this.album = Album;
        }

        public Music(string Title, string Artist, 
            string Album,int TimeStart, int TimeEnd,
            string PathAlbum  )
        {
            title = Title;
            artist = Artist;
            album = Album;
            this.TimeStart = TimeStart;
            this.TimeEnd = TimeEnd;
            this.PathAlbum = PathAlbum; 

        }




        #endregion

        #region ICaratula


        public int TimeStart { 
            get => timeStart; 
            set => timeStart = value; 
        }
        public int TimeEnd { 
            get => timeEnd; 
            set => timeEnd = value; 
        }
        public string PathAlbum { 
            get => pathAlbum;
            set => pathAlbum = value; 
        }

        #endregion


    }
}
