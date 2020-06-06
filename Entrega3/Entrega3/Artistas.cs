using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entrega3
{
    public partial class Artistas : Form
    {
        string[]artistas_disponibles;   //   []   \
        public Artistas()
        {
            InitializeComponent();
            string listados_artistas = Properties.Resources.artistas.ToString();
            artistas_disponibles = listados_artistas.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Artistas_Load(object sender, EventArgs e)
        {
            popularArtistas();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void popularArtistas()
        {
            for (int i =0; i<artistas_disponibles.Length;i++)
            {
                CBArtistas.Items.Add(artistas_disponibles[i]);
            }
        }
    }
}
