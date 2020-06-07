﻿using System;
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
    public partial class MenuCanciones : Form
    {
        public MenuCanciones()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ReproductorCanciones ventanaReproductorCanciones = new ReproductorCanciones())
                ventanaReproductorCanciones.ShowDialog();
        }

        private void btnBuscaArtista_Click(object sender, EventArgs e)
        {
            using (Artistas ventanaArtistas = new Artistas())
                ventanaArtistas.ShowDialog();
        }

        private void btnBuscaPlaylist_Click(object sender, EventArgs e)
        {

        }
    }
}