namespace Entrega3
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.btnSongs = new System.Windows.Forms.Button();
            this.btnMovies = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGotoPlaylists1 = new System.Windows.Forms.Button();
            this.panelPlaylistC = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAdjuntar = new System.Windows.Forms.PictureBox();
            this.lstCanciones = new System.Windows.Forms.ListBox();
            this.axWindowsMediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnBacktoRepMus = new System.Windows.Forms.Button();
            this.btnBacktoPanel1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panelBusquedaC = new System.Windows.Forms.Panel();
            this.btnBacktoRepMus2 = new System.Windows.Forms.Button();
            this.btnGotoPlaylistPanel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBacktoPanel1C = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRuta = new System.Windows.Forms.Label();
            this.btnIraPanel2C = new System.Windows.Forms.Button();
            this.btnBackToMenuS = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReproducir = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnBackfromMP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelPlaylistC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdjuntar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panelBusquedaC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSongs
            // 
            this.btnSongs.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSongs.ForeColor = System.Drawing.Color.Lime;
            this.btnSongs.Location = new System.Drawing.Point(29, 151);
            this.btnSongs.Name = "btnSongs";
            this.btnSongs.Size = new System.Drawing.Size(117, 70);
            this.btnSongs.TabIndex = 0;
            this.btnSongs.Text = "CANCIONES";
            this.btnSongs.UseVisualStyleBackColor = false;
            this.btnSongs.Click += new System.EventHandler(this.btnSongs_Click);
            // 
            // btnMovies
            // 
            this.btnMovies.BackColor = System.Drawing.Color.Red;
            this.btnMovies.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMovies.Location = new System.Drawing.Point(357, 152);
            this.btnMovies.Name = "btnMovies";
            this.btnMovies.Size = new System.Drawing.Size(117, 70);
            this.btnMovies.TabIndex = 1;
            this.btnMovies.Text = "PELÍCULAS";
            this.btnMovies.UseVisualStyleBackColor = false;
            this.btnMovies.Click += new System.EventHandler(this.btnMovies_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSalir.Location = new System.Drawing.Point(376, 349);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(98, 41);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(102, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menú Usuario Spotflix";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Entrega3.Properties.Resources.preview;
            this.pictureBox1.Location = new System.Drawing.Point(-118, -92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(751, 613);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGotoPlaylists1);
            this.panel1.Controls.Add(this.panelPlaylistC);
            this.panel1.Controls.Add(this.panelBusquedaC);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblRuta);
            this.panel1.Controls.Add(this.btnIraPanel2C);
            this.panel1.Controls.Add(this.btnBackToMenuS);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnReproducir);
            this.panel1.Controls.Add(this.btnCargar);
            this.panel1.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 402);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // btnGotoPlaylists1
            // 
            this.btnGotoPlaylists1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGotoPlaylists1.Location = new System.Drawing.Point(130, 362);
            this.btnGotoPlaylists1.Name = "btnGotoPlaylists1";
            this.btnGotoPlaylists1.Size = new System.Drawing.Size(112, 28);
            this.btnGotoPlaylists1.TabIndex = 12;
            this.btnGotoPlaylists1.Text = "Playlists";
            this.btnGotoPlaylists1.UseVisualStyleBackColor = true;
            this.btnGotoPlaylists1.Click += new System.EventHandler(this.btnGotoPlaylists1_Click_1);
            // 
            // panelPlaylistC
            // 
            this.panelPlaylistC.Controls.Add(this.btnBackfromMP);
            this.panelPlaylistC.Controls.Add(this.label8);
            this.panelPlaylistC.Controls.Add(this.btnAdjuntar);
            this.panelPlaylistC.Controls.Add(this.lstCanciones);
            this.panelPlaylistC.Controls.Add(this.axWindowsMediaPlayer2);
            this.panelPlaylistC.Controls.Add(this.btnBacktoRepMus);
            this.panelPlaylistC.Controls.Add(this.btnBacktoPanel1);
            this.panelPlaylistC.Controls.Add(this.label7);
            this.panelPlaylistC.Controls.Add(this.pictureBox4);
            this.panelPlaylistC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPlaylistC.Location = new System.Drawing.Point(0, 0);
            this.panelPlaylistC.Name = "panelPlaylistC";
            this.panelPlaylistC.Size = new System.Drawing.Size(504, 402);
            this.panelPlaylistC.TabIndex = 11;
            this.panelPlaylistC.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(57, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Añadir Canciones";
            // 
            // btnAdjuntar
            // 
            this.btnAdjuntar.Image = global::Entrega3.Properties.Resources.plus_button;
            this.btnAdjuntar.Location = new System.Drawing.Point(15, 151);
            this.btnAdjuntar.Name = "btnAdjuntar";
            this.btnAdjuntar.Size = new System.Drawing.Size(36, 31);
            this.btnAdjuntar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdjuntar.TabIndex = 11;
            this.btnAdjuntar.TabStop = false;
            this.btnAdjuntar.Click += new System.EventHandler(this.btnAdjuntar_Click);
            // 
            // lstCanciones
            // 
            this.lstCanciones.FormattingEnabled = true;
            this.lstCanciones.Location = new System.Drawing.Point(15, 191);
            this.lstCanciones.Name = "lstCanciones";
            this.lstCanciones.Size = new System.Drawing.Size(357, 147);
            this.lstCanciones.TabIndex = 10;
            this.lstCanciones.SelectedIndexChanged += new System.EventHandler(this.lstCanciones_SelectedIndexChanged);
            // 
            // axWindowsMediaPlayer2
            // 
            this.axWindowsMediaPlayer2.Enabled = true;
            this.axWindowsMediaPlayer2.Location = new System.Drawing.Point(15, 43);
            this.axWindowsMediaPlayer2.Name = "axWindowsMediaPlayer2";
            this.axWindowsMediaPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer2.OcxState")));
            this.axWindowsMediaPlayer2.Size = new System.Drawing.Size(357, 86);
            this.axWindowsMediaPlayer2.TabIndex = 9;
            this.axWindowsMediaPlayer2.Enter += new System.EventHandler(this.axWindowsMediaPlayer2_Enter);
            // 
            // btnBacktoRepMus
            // 
            this.btnBacktoRepMus.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBacktoRepMus.Location = new System.Drawing.Point(12, 362);
            this.btnBacktoRepMus.Name = "btnBacktoRepMus";
            this.btnBacktoRepMus.Size = new System.Drawing.Size(112, 28);
            this.btnBacktoRepMus.TabIndex = 8;
            this.btnBacktoRepMus.Text = "Rep. Música";
            this.btnBacktoRepMus.UseVisualStyleBackColor = true;
            this.btnBacktoRepMus.Click += new System.EventHandler(this.btnBacktoRepMus_Click);
            // 
            // btnBacktoPanel1
            // 
            this.btnBacktoPanel1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBacktoPanel1.Location = new System.Drawing.Point(130, 362);
            this.btnBacktoPanel1.Name = "btnBacktoPanel1";
            this.btnBacktoPanel1.Size = new System.Drawing.Size(112, 28);
            this.btnBacktoPanel1.TabIndex = 7;
            this.btnBacktoPanel1.Text = "Búsquedas";
            this.btnBacktoPanel1.UseVisualStyleBackColor = true;
            this.btnBacktoPanel1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(12, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Menú Playlists:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Entrega3.Properties.Resources.preview1;
            this.pictureBox4.Location = new System.Drawing.Point(-129, -66);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(746, 535);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // panelBusquedaC
            // 
            this.panelBusquedaC.Controls.Add(this.btnBacktoRepMus2);
            this.panelBusquedaC.Controls.Add(this.btnGotoPlaylistPanel);
            this.panelBusquedaC.Controls.Add(this.label6);
            this.panelBusquedaC.Controls.Add(this.btnBacktoPanel1C);
            this.panelBusquedaC.Controls.Add(this.label5);
            this.panelBusquedaC.Controls.Add(this.label4);
            this.panelBusquedaC.Controls.Add(this.textBox1);
            this.panelBusquedaC.Controls.Add(this.pictureBox3);
            this.panelBusquedaC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBusquedaC.Location = new System.Drawing.Point(0, 0);
            this.panelBusquedaC.Name = "panelBusquedaC";
            this.panelBusquedaC.Size = new System.Drawing.Size(504, 402);
            this.panelBusquedaC.TabIndex = 9;
            this.panelBusquedaC.Visible = false;
            // 
            // btnBacktoRepMus2
            // 
            this.btnBacktoRepMus2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBacktoRepMus2.Location = new System.Drawing.Point(12, 362);
            this.btnBacktoRepMus2.Name = "btnBacktoRepMus2";
            this.btnBacktoRepMus2.Size = new System.Drawing.Size(112, 28);
            this.btnBacktoRepMus2.TabIndex = 12;
            this.btnBacktoRepMus2.Text = "Rep. Música";
            this.btnBacktoRepMus2.UseVisualStyleBackColor = true;
            this.btnBacktoRepMus2.Click += new System.EventHandler(this.btnBacktoRepMus2_Click);
            // 
            // btnGotoPlaylistPanel
            // 
            this.btnGotoPlaylistPanel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGotoPlaylistPanel.Location = new System.Drawing.Point(130, 362);
            this.btnGotoPlaylistPanel.Name = "btnGotoPlaylistPanel";
            this.btnGotoPlaylistPanel.Size = new System.Drawing.Size(112, 28);
            this.btnGotoPlaylistPanel.TabIndex = 10;
            this.btnGotoPlaylistPanel.Text = "Playlists";
            this.btnGotoPlaylistPanel.UseVisualStyleBackColor = true;
            this.btnGotoPlaylistPanel.Click += new System.EventHandler(this.btnGotoPlaylistPanel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(12, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Reproductor de Música:";
            // 
            // btnBacktoPanel1C
            // 
            this.btnBacktoPanel1C.Location = new System.Drawing.Point(417, 371);
            this.btnBacktoPanel1C.Name = "btnBacktoPanel1C";
            this.btnBacktoPanel1C.Size = new System.Drawing.Size(75, 23);
            this.btnBacktoPanel1C.TabIndex = 4;
            this.btnBacktoPanel1C.Text = "VOLVER";
            this.btnBacktoPanel1C.UseVisualStyleBackColor = true;
            this.btnBacktoPanel1C.Click += new System.EventHandler(this.btnBacktoPanel1C_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(12, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Búsquedas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(9, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Buscar:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(89, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(302, 23);
            this.textBox1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Entrega3.Properties.Resources.preview1;
            this.pictureBox3.Location = new System.Drawing.Point(-109, -46);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(716, 494);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(289, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Información:";
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRuta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRuta.Location = new System.Drawing.Point(51, 272);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(0, 13);
            this.lblRuta.TabIndex = 7;
            // 
            // btnIraPanel2C
            // 
            this.btnIraPanel2C.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIraPanel2C.Location = new System.Drawing.Point(12, 362);
            this.btnIraPanel2C.Name = "btnIraPanel2C";
            this.btnIraPanel2C.Size = new System.Drawing.Size(112, 28);
            this.btnIraPanel2C.TabIndex = 6;
            this.btnIraPanel2C.Text = "Búsquedas";
            this.btnIraPanel2C.UseVisualStyleBackColor = true;
            this.btnIraPanel2C.Click += new System.EventHandler(this.btnIraPanel2C_Click);
            // 
            // btnBackToMenuS
            // 
            this.btnBackToMenuS.BackColor = System.Drawing.Color.Red;
            this.btnBackToMenuS.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMenuS.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBackToMenuS.Location = new System.Drawing.Point(417, 355);
            this.btnBackToMenuS.Name = "btnBackToMenuS";
            this.btnBackToMenuS.Size = new System.Drawing.Size(75, 40);
            this.btnBackToMenuS.TabIndex = 5;
            this.btnBackToMenuS.Text = "VOLVER";
            this.btnBackToMenuS.UseVisualStyleBackColor = false;
            this.btnBackToMenuS.Click += new System.EventHandler(this.btnBackToMenuS_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ruta:";
            // 
            // btnReproducir
            // 
            this.btnReproducir.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReproducir.Location = new System.Drawing.Point(152, 303);
            this.btnReproducir.Name = "btnReproducir";
            this.btnReproducir.Size = new System.Drawing.Size(130, 37);
            this.btnReproducir.TabIndex = 3;
            this.btnReproducir.Text = "REPRODUCIR";
            this.btnReproducir.UseVisualStyleBackColor = true;
            this.btnReproducir.Click += new System.EventHandler(this.btnReproducir_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(12, 303);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(130, 37);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "CARGAR";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 42);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(270, 227);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Entrega3.Properties.Resources.preview1;
            this.pictureBox2.Location = new System.Drawing.Point(-118, -92);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(725, 588);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "mp3|mp3";
            // 
            // btnBackfromMP
            // 
            this.btnBackfromMP.BackColor = System.Drawing.Color.Red;
            this.btnBackfromMP.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackfromMP.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBackfromMP.Location = new System.Drawing.Point(416, 349);
            this.btnBackfromMP.Name = "btnBackfromMP";
            this.btnBackfromMP.Size = new System.Drawing.Size(75, 41);
            this.btnBackfromMP.TabIndex = 13;
            this.btnBackfromMP.Text = "VOLVER";
            this.btnBackfromMP.UseVisualStyleBackColor = false;
            this.btnBackfromMP.Click += new System.EventHandler(this.btnBackfromMP_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 402);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMovies);
            this.Controls.Add(this.btnSongs);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "MenuPrincipal";
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelPlaylistC.ResumeLayout(false);
            this.panelPlaylistC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdjuntar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panelBusquedaC.ResumeLayout(false);
            this.panelBusquedaC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSongs;
        private System.Windows.Forms.Button btnMovies;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCargar;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnIraPanel2C;
        private System.Windows.Forms.Button btnBackToMenuS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReproducir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelBusquedaC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnBacktoPanel1C;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelPlaylistC;
        private System.Windows.Forms.Button btnGotoPlaylistPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnBacktoPanel1;
        private System.Windows.Forms.Button btnBacktoRepMus;
        private System.Windows.Forms.Button btnBacktoRepMus2;
        private System.Windows.Forms.Button btnGotoPlaylists1;
        private System.Windows.Forms.PictureBox btnAdjuntar;
        private System.Windows.Forms.ListBox lstCanciones;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBackfromMP;
    }
}

