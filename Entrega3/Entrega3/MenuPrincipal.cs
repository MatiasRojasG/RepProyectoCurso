using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entrega3
{
    public partial class MenuPrincipal : Form
    {
        bool Play = false;
        string[] ArchivosMP3;
        string[] rutasArchivosMP3;
        private string ruta = "";     //     [ ]
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSongs_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panelBusquedaC.Visible = false;
            label6.Visible = true;
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBackToMenuS_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panelBusquedaC.Visible = false;
            panelPlaylistC.Visible = false;
            
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                ruta = openFileDialog1.FileName;
                lblRuta.Text = ruta;
            }
        }

        private void btnReproducir_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = ruta;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void btnBacktoPanel1C_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label6.Visible = true;
            panelBusquedaC.Visible = false;
        }

        private void btnIraPanel2C_Click(object sender, EventArgs e)
        {
            panelBusquedaC.Visible = true;
            label6.Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnGotoPlaylistPanel_Click(object sender, EventArgs e)
        {
            panelPlaylistC.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelBusquedaC.Visible = true;
            panelPlaylistC.Visible = false;
        }

        private void btnBacktoRepMus_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label6.Visible = true;
            panelBusquedaC.Visible = false;
            panelPlaylistC.Visible = false;

        }

        private void btnBacktoRepMus2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label6.Visible = true;
            panelBusquedaC.Visible = false;
        }



        private void btnGotoPlaylists1_Click_1(object sender, EventArgs e)
        {
            panelPlaylistC.Visible = true;
            btnGotoPlaylists1.Visible = false;
        }

        private void btnAdjuntar_Click(object sender, EventArgs e)
        {
            OpenFileDialog CajadeBusquedaDeArchivos = new OpenFileDialog();
            CajadeBusquedaDeArchivos.Multiselect = true;
            if (CajadeBusquedaDeArchivos.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ArchivosMP3 = CajadeBusquedaDeArchivos.SafeFileNames;
                rutasArchivosMP3 = CajadeBusquedaDeArchivos.FileNames;
                foreach (var ArchivoMP3 in ArchivosMP3)
                {
                    lstCanciones.Items.Add(ArchivoMP3);
                }
                axWindowsMediaPlayer2.currentPlaylist = axWindowsMediaPlayer2.newPlaylist("aa", "");
                foreach(string fn in CajadeBusquedaDeArchivos.FileNames)
                {
                    axWindowsMediaPlayer2.currentPlaylist.appendItem(axWindowsMediaPlayer2.newMedia(fn));
                }
                axWindowsMediaPlayer2.Ctlcontrols.play();  
            }
        }

        private void lstCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.URL = rutasArchivosMP3[lstCanciones.SelectedIndex];
        }

        private void axWindowsMediaPlayer2_Enter(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.next();
        }

        private void btnBackfromMP_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panelBusquedaC.Visible = false;
            panelPlaylistC.Visible = false;
        }
    }
}
