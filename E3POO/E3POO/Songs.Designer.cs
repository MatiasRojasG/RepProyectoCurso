namespace E3POO
{
    partial class Songs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Songs));
            this.label1 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnCargarRep = new System.Windows.Forms.Button();
            this.lstCancionesRep = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBusquedafromRep = new System.Windows.Forms.Button();
            this.btnPlaylistsfromRep = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelPlaylists = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.lstCancionesPlay = new System.Windows.Forms.ListBox();
            this.btnCargarPlay = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBusquedafromPlaylist = new System.Windows.Forms.Button();
            this.btnSalirPlay = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelBusquedas = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnExitfromPlay = new System.Windows.Forms.Button();
            this.btnRepMfromBusquedas = new System.Windows.Forms.Button();
            this.btnPlaylistsfromBusquedas = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panelPlaylists.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBusquedas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reproductor:";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(225, 79);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(383, 276);
            this.axWindowsMediaPlayer1.TabIndex = 2;
            // 
            // btnCargarRep
            // 
            this.btnCargarRep.BackColor = System.Drawing.Color.Red;
            this.btnCargarRep.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarRep.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCargarRep.Location = new System.Drawing.Point(225, 50);
            this.btnCargarRep.Name = "btnCargarRep";
            this.btnCargarRep.Size = new System.Drawing.Size(75, 23);
            this.btnCargarRep.TabIndex = 3;
            this.btnCargarRep.Text = "Cargar";
            this.btnCargarRep.UseVisualStyleBackColor = false;
            this.btnCargarRep.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstCancionesRep
            // 
            this.lstCancionesRep.FormattingEnabled = true;
            this.lstCancionesRep.Location = new System.Drawing.Point(17, 79);
            this.lstCancionesRep.Name = "lstCancionesRep";
            this.lstCancionesRep.Size = new System.Drawing.Size(202, 277);
            this.lstCancionesRep.TabIndex = 4;
            this.lstCancionesRep.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(547, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnBusquedafromRep
            // 
            this.btnBusquedafromRep.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusquedafromRep.Location = new System.Drawing.Point(17, 386);
            this.btnBusquedafromRep.Name = "btnBusquedafromRep";
            this.btnBusquedafromRep.Size = new System.Drawing.Size(91, 23);
            this.btnBusquedafromRep.TabIndex = 6;
            this.btnBusquedafromRep.Text = "Búsqueda";
            this.btnBusquedafromRep.UseVisualStyleBackColor = true;
            this.btnBusquedafromRep.Click += new System.EventHandler(this.btnBusquedafromRep_Click);
            // 
            // btnPlaylistsfromRep
            // 
            this.btnPlaylistsfromRep.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaylistsfromRep.Location = new System.Drawing.Point(114, 386);
            this.btnPlaylistsfromRep.Name = "btnPlaylistsfromRep";
            this.btnPlaylistsfromRep.Size = new System.Drawing.Size(91, 23);
            this.btnPlaylistsfromRep.TabIndex = 7;
            this.btnPlaylistsfromRep.Text = "Playlists";
            this.btnPlaylistsfromRep.UseVisualStyleBackColor = true;
            this.btnPlaylistsfromRep.Click += new System.EventHandler(this.btnPlaylistsfromRep_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "mp3|mp3";
            // 
            // panelPlaylists
            // 
            this.panelPlaylists.Controls.Add(this.panelBusquedas);
            this.panelPlaylists.Controls.Add(this.button4);
            this.panelPlaylists.Controls.Add(this.label3);
            this.panelPlaylists.Controls.Add(this.label2);
            this.panelPlaylists.Controls.Add(this.button3);
            this.panelPlaylists.Controls.Add(this.btnSalirPlay);
            this.panelPlaylists.Controls.Add(this.btnBusquedafromPlaylist);
            this.panelPlaylists.Controls.Add(this.button2);
            this.panelPlaylists.Controls.Add(this.btnCargarPlay);
            this.panelPlaylists.Controls.Add(this.lstCancionesPlay);
            this.panelPlaylists.Controls.Add(this.axWindowsMediaPlayer2);
            this.panelPlaylists.Controls.Add(this.pictureBox2);
            this.panelPlaylists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPlaylists.Location = new System.Drawing.Point(0, 0);
            this.panelPlaylists.Name = "panelPlaylists";
            this.panelPlaylists.Size = new System.Drawing.Size(645, 421);
            this.panelPlaylists.TabIndex = 8;
            this.panelPlaylists.Visible = false;
            // 
            // axWindowsMediaPlayer2
            // 
            this.axWindowsMediaPlayer2.Enabled = true;
            this.axWindowsMediaPlayer2.Location = new System.Drawing.Point(17, 79);
            this.axWindowsMediaPlayer2.Name = "axWindowsMediaPlayer2";
            this.axWindowsMediaPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer2.OcxState")));
            this.axWindowsMediaPlayer2.Size = new System.Drawing.Size(420, 106);
            this.axWindowsMediaPlayer2.TabIndex = 1;
            // 
            // lstCancionesPlay
            // 
            this.lstCancionesPlay.FormattingEnabled = true;
            this.lstCancionesPlay.Location = new System.Drawing.Point(17, 243);
            this.lstCancionesPlay.Name = "lstCancionesPlay";
            this.lstCancionesPlay.Size = new System.Drawing.Size(420, 121);
            this.lstCancionesPlay.TabIndex = 2;
            this.lstCancionesPlay.SelectedIndexChanged += new System.EventHandler(this.lstCancionesPlay_SelectedIndexChanged);
            // 
            // btnCargarPlay
            // 
            this.btnCargarPlay.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarPlay.Location = new System.Drawing.Point(17, 201);
            this.btnCargarPlay.Name = "btnCargarPlay";
            this.btnCargarPlay.Size = new System.Drawing.Size(152, 23);
            this.btnCargarPlay.TabIndex = 3;
            this.btnCargarPlay.Text = "CARGAR";
            this.btnCargarPlay.UseVisualStyleBackColor = true;
            this.btnCargarPlay.Click += new System.EventHandler(this.btnCargarPlay_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(17, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Rep Música";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBusquedafromPlaylist
            // 
            this.btnBusquedafromPlaylist.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusquedafromPlaylist.Location = new System.Drawing.Point(119, 380);
            this.btnBusquedafromPlaylist.Name = "btnBusquedafromPlaylist";
            this.btnBusquedafromPlaylist.Size = new System.Drawing.Size(96, 23);
            this.btnBusquedafromPlaylist.TabIndex = 5;
            this.btnBusquedafromPlaylist.Text = "Búsqueda";
            this.btnBusquedafromPlaylist.UseVisualStyleBackColor = true;
            this.btnBusquedafromPlaylist.Click += new System.EventHandler(this.btnBusquedafromPlaylist_Click);
            // 
            // btnSalirPlay
            // 
            this.btnSalirPlay.BackColor = System.Drawing.Color.Red;
            this.btnSalirPlay.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirPlay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalirPlay.Location = new System.Drawing.Point(547, 368);
            this.btnSalirPlay.Name = "btnSalirPlay";
            this.btnSalirPlay.Size = new System.Drawing.Size(85, 35);
            this.btnSalirPlay.TabIndex = 6;
            this.btnSalirPlay.Text = "SALIR";
            this.btnSalirPlay.UseVisualStyleBackColor = false;
            this.btnSalirPlay.Click += new System.EventHandler(this.btnSalirPlay_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(462, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "BUSCAR PLAYLIST";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(17, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Playlists:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(14, 227);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Canciones:";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(175, 201);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "ELIMINAR CANCIÓN";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::E3POO.Properties.Resources.preview;
            this.pictureBox2.Location = new System.Drawing.Point(-73, -68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(803, 563);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::E3POO.Properties.Resources.preview;
            this.pictureBox1.Location = new System.Drawing.Point(-77, -55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(790, 543);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelBusquedas
            // 
            this.panelBusquedas.Controls.Add(this.textBox1);
            this.panelBusquedas.Controls.Add(this.label4);
            this.panelBusquedas.Controls.Add(this.btnPlaylistsfromBusquedas);
            this.panelBusquedas.Controls.Add(this.btnRepMfromBusquedas);
            this.panelBusquedas.Controls.Add(this.btnExitfromPlay);
            this.panelBusquedas.Controls.Add(this.pictureBox3);
            this.panelBusquedas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBusquedas.Location = new System.Drawing.Point(0, 0);
            this.panelBusquedas.Name = "panelBusquedas";
            this.panelBusquedas.Size = new System.Drawing.Size(645, 421);
            this.panelBusquedas.TabIndex = 11;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::E3POO.Properties.Resources.preview;
            this.pictureBox3.Location = new System.Drawing.Point(-73, -68);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(766, 548);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // btnExitfromPlay
            // 
            this.btnExitfromPlay.BackColor = System.Drawing.Color.Red;
            this.btnExitfromPlay.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitfromPlay.Location = new System.Drawing.Point(547, 368);
            this.btnExitfromPlay.Name = "btnExitfromPlay";
            this.btnExitfromPlay.Size = new System.Drawing.Size(84, 41);
            this.btnExitfromPlay.TabIndex = 1;
            this.btnExitfromPlay.Text = "SALIR";
            this.btnExitfromPlay.UseVisualStyleBackColor = false;
            this.btnExitfromPlay.Click += new System.EventHandler(this.btnExitfromPlay_Click);
            // 
            // btnRepMfromBusquedas
            // 
            this.btnRepMfromBusquedas.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepMfromBusquedas.Location = new System.Drawing.Point(17, 380);
            this.btnRepMfromBusquedas.Name = "btnRepMfromBusquedas";
            this.btnRepMfromBusquedas.Size = new System.Drawing.Size(109, 23);
            this.btnRepMfromBusquedas.TabIndex = 2;
            this.btnRepMfromBusquedas.Text = "REP MUSICA";
            this.btnRepMfromBusquedas.UseVisualStyleBackColor = true;
            this.btnRepMfromBusquedas.Click += new System.EventHandler(this.btnRepMfromBusquedas_Click);
            // 
            // btnPlaylistsfromBusquedas
            // 
            this.btnPlaylistsfromBusquedas.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaylistsfromBusquedas.Location = new System.Drawing.Point(132, 380);
            this.btnPlaylistsfromBusquedas.Name = "btnPlaylistsfromBusquedas";
            this.btnPlaylistsfromBusquedas.Size = new System.Drawing.Size(114, 23);
            this.btnPlaylistsfromBusquedas.TabIndex = 3;
            this.btnPlaylistsfromBusquedas.Text = "PLAYLISTS";
            this.btnPlaylistsfromBusquedas.UseVisualStyleBackColor = true;
            this.btnPlaylistsfromBusquedas.Click += new System.EventHandler(this.btnPlaylistsfromBusquedas_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(70, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Buscar:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(150, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(370, 22);
            this.textBox1.TabIndex = 5;
            // 
            // Songs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 421);
            this.Controls.Add(this.panelPlaylists);
            this.Controls.Add(this.btnPlaylistsfromRep);
            this.Controls.Add(this.btnBusquedafromRep);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstCancionesRep);
            this.Controls.Add(this.btnCargarRep);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Songs";
            this.Text = "Songs";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panelPlaylists.ResumeLayout(false);
            this.panelPlaylists.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBusquedas.ResumeLayout(false);
            this.panelBusquedas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btnCargarRep;
        private System.Windows.Forms.ListBox lstCancionesRep;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBusquedafromRep;
        private System.Windows.Forms.Button btnPlaylistsfromRep;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panelPlaylists;
        private System.Windows.Forms.Button btnSalirPlay;
        private System.Windows.Forms.Button btnBusquedafromPlaylist;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCargarPlay;
        private System.Windows.Forms.ListBox lstCancionesPlay;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panelBusquedas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPlaylistsfromBusquedas;
        private System.Windows.Forms.Button btnRepMfromBusquedas;
        private System.Windows.Forms.Button btnExitfromPlay;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}