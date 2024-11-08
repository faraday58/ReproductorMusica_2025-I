
using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace ReproductorMusica_2025_I
{
    public partial class FormReproductor : Form
    {
       
        private List<Music> songs;




        public FormReproductor()
        {
            InitializeComponent();
            songs = new List<Music>();
            loadSongs();
            /// lbDirectorio.Text += " " + Environment.CurrentDirectory;
            // ptbAlbum.Image = Image.FromFile(@"..\..\Resources\jazz_queen_album.png");
            lbPath.Text += " " + Environment.CurrentDirectory;


            ptbAlbum.Image = Image.FromFile(@"..\..\Resources\jazz_queen_album.png");
        }

        private void loadSongs()
        {
            songs.Add(
                new Music("Besos en Guerra","Morat","Balas Perdidas",0,120, @"..\..\Resources\balas_perdidas.jpg"));
            songs.Add(
                new Music("Lento", "Julieta Venegas", "Sí",0,180, @"..\..\Resources\si.jpg"));
            songs.Add(
                new Music("Dynamite", "Talio Cruz", "Rock Star",0,140, @"..\..\Resources\taio_cruz_rockstar.png"));


            foreach (var song in songs)
            {
                lstbSongs.Items.Add(song.title);
            }

        }

        private void receivedSong(Music song)
        {
            songs.Add(song);
            lstbSongs.Items.Add(song.title);

        }

        
        private void lstbSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            Music song = songs[lstbSongs.SelectedIndex];
            lbArtist.Text = song.artist;
            lbTitle.Text = song.title;
            lbAlbum.Text = song.album;
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregar formAgregar = new FormAgregar();
            formAgregar.SendSong += receivedSong;
            formAgregar.ShowDialog();


        }

        private void FormReproductor_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sw = new SaveFileDialog();
            sw.Filter = "csv|*.csv";
            StreamWriter swr = null;
            if ( sw.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    swr = new StreamWriter(sw.FileName);

                    swr.WriteLine("Title,Artist,Album" );

                    foreach (Music song in  songs )
                    {
                        swr.WriteLine("{0},{1},{2}",
                            song.title,song.artist,song.album);
                    }

                    
                }
                catch (IOException error) {
                    MessageBox.Show(error.Message);
                }
                finally
                {
                    swr.Close();
                }
                


            }

        }
    }
}
