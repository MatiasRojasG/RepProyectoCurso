using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E3POO
{
    public partial class Songs : Form
    {
        string[] ArchivosMP3;
        string[] rutasArchivosMP3;
        string[] aArchivosMP3;
        string[] arutasArchivosMP3;
        public Songs()
        {
            InitializeComponent();              //           []
        }


        //Menu Reproductor de Música
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog CajadeBusquedaDeArchivos = new OpenFileDialog();
            CajadeBusquedaDeArchivos.Multiselect = true;
            if(CajadeBusquedaDeArchivos.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                ArchivosMP3 = CajadeBusquedaDeArchivos.SafeFileNames;
                rutasArchivosMP3 = CajadeBusquedaDeArchivos.FileNames;
                foreach(var ArchivoMP3 in ArchivosMP3)
                {
                    lstCancionesRep.Items.Add(ArchivoMP3);
                }
                axWindowsMediaPlayer1.URL = rutasArchivosMP3[0];
                lstCancionesRep.SelectedIndex = 0;
            }
        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                axWindowsMediaPlayer1.URL = rutasArchivosMP3[lstCancionesRep.SelectedIndex];
            }
            catch
            {
                
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalirPlay_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlaylistsfromRep_Click(object sender, EventArgs e)
        {
            panelPlaylists.Visible = true;
        }

        private void btnCargarPlay_Click(object sender, EventArgs e)
        {
            OpenFileDialog PCajadeBusquedaDeArchivos = new OpenFileDialog();
            PCajadeBusquedaDeArchivos.Multiselect = true;
            if (PCajadeBusquedaDeArchivos.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                axWindowsMediaPlayer2.currentPlaylist = axWindowsMediaPlayer2.newPlaylist("aa", "");
                foreach(string fn in PCajadeBusquedaDeArchivos.FileNames)
                {
                    axWindowsMediaPlayer2.currentPlaylist.appendItem(axWindowsMediaPlayer2.newMedia(fn));
                    
                }
                axWindowsMediaPlayer2.Ctlcontrols.play();
                //Listbox
                aArchivosMP3 = PCajadeBusquedaDeArchivos.SafeFileNames;
                arutasArchivosMP3 = PCajadeBusquedaDeArchivos.FileNames;
                foreach (var ArchivoMP3 in aArchivosMP3)
                {
                    lstCancionesPlay.Items.Add(ArchivoMP3);
                }
            }
        }

        private void lstCancionesPlay_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                axWindowsMediaPlayer2.URL = arutasArchivosMP3[lstCancionesPlay.SelectedIndex];
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelPlaylists.Visible = false;
            panelBusquedas.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lstCancionesPlay.Items.Remove(lstCancionesPlay.SelectedItem);
        }

        private void btnBusquedafromPlaylist_Click(object sender, EventArgs e)
        {
            panelBusquedas.Visible = false;
            panelPlaylists.Visible = false;
            panelBusquedas.Visible = true;

        }

        private void btnBusquedafromRep_Click(object sender, EventArgs e)
        {
            panelBusquedas.Visible = true;
            panelPlaylists.Visible = false;
        }

        private void btnPlaylistsfromBusquedas_Click(object sender, EventArgs e)
        {
            panelPlaylists.Visible = true;
            panelBusquedas.Visible = false;
        }

        private void btnRepMfromBusquedas_Click(object sender, EventArgs e)
        {
            panelPlaylists.Visible = false;
            panelBusquedas.Visible = false;
        }

        private void btnExitfromPlay_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
