using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E3POO
{
    public partial class Movies : Form
    {
        private string ruta = "";
        public Movies()
        {
            InitializeComponent();
        }

        private void btnCargarMovie_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                ruta = openFileDialog1.FileName;
                lblRuta.Text = ruta;
                axWindowsMediaPlayer1.URL = ruta;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
