using System;
using System.Windows.Forms;

namespace ReproductorMusica_2025_I
{
    public partial class FormAgregar : Form
    {
        internal delegate void DelegateSong(Music song);
        internal event DelegateSong SendSong;


        public FormAgregar()
        {
            InitializeComponent();
        }



        private void txtbAlbum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (  e.KeyChar ==(char)Keys.Enter    )
            {
                Music song = new Music(txtbTitle.Text, 
                    txtbArtist.Text,
                txtbAlbum.Text);
                
                SendSong(song);
                
                
            }
            
        }
    }
}
