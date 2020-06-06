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
    public partial class MenuPrincipal : Form
    {
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
            using (MenuCanciones ventanamenucanciones = new MenuCanciones())
                ventanamenucanciones.ShowDialog();
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            using (MenuPelículas ventanamenupeliculas = new MenuPelículas())
                ventanamenupeliculas.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
