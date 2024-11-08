

namespace ReproductorMusica_2025_I
{
    internal struct Music:ICaratula 
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
