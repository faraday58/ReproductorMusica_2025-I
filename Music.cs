

namespace ReproductorMusica_2025_I
{
    internal struct Music : ICaratula
    {
        #region Campos
        internal string title;
        internal string artist;
        internal string album;
        #endregion

        #region Constructor
        public Music(string Title, string Artist, string Album)
        {
            this.title = Title;
            this.artist = Artist;
            this.album = Album;
        }

        public Music(string Title, string Artist, string Album,
            int timeStart, int timeEnd, string pathAlbum)
        {
            this.title = Title;
            this.artist = Artist;
            this.album = Album;
            this.timeStart = timeStart;
            this.timeEnd = timeEnd;
            this.pathAlbum = pathAlbum;

        }

        #endregion

        #region ICaratula
      

        public int timeEnd {
            get => this.timeEnd;
            set
            {

            }
        }

        public string pathAlbum {
            get => this.pathAlbum;
            set => this.pathAlbum = value;
        }


        #endregion


    }
}
