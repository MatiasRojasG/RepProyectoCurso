namespace Entrega3
{
    partial class MenuCanciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBuscaArtista = new System.Windows.Forms.Button();
            this.btnBuscaPlaylist = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "CANCIONES";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Red;
            this.btnVolver.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnVolver.Location = new System.Drawing.Point(384, 335);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(89, 42);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(315, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "Reproducir Canciones";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscaArtista
            // 
            this.btnBuscaArtista.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscaArtista.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaArtista.Location = new System.Drawing.Point(315, 180);
            this.btnBuscaArtista.Name = "btnBuscaArtista";
            this.btnBuscaArtista.Size = new System.Drawing.Size(158, 56);
            this.btnBuscaArtista.TabIndex = 3;
            this.btnBuscaArtista.Text = "Buscar Artista";
            this.btnBuscaArtista.UseVisualStyleBackColor = false;
            this.btnBuscaArtista.Click += new System.EventHandler(this.btnBuscaArtista_Click);
            // 
            // btnBuscaPlaylist
            // 
            this.btnBuscaPlaylist.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscaPlaylist.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaPlaylist.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscaPlaylist.Location = new System.Drawing.Point(315, 242);
            this.btnBuscaPlaylist.Name = "btnBuscaPlaylist";
            this.btnBuscaPlaylist.Size = new System.Drawing.Size(158, 56);
            this.btnBuscaPlaylist.TabIndex = 4;
            this.btnBuscaPlaylist.Text = "Buscar Playlist";
            this.btnBuscaPlaylist.UseVisualStyleBackColor = false;
            this.btnBuscaPlaylist.Click += new System.EventHandler(this.btnBuscaPlaylist_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Entrega3.Properties.Resources.preview1;
            this.pictureBox1.Location = new System.Drawing.Point(-128, -43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(753, 466);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MenuCanciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 389);
            this.Controls.Add(this.btnBuscaPlaylist);
            this.Controls.Add(this.btnBuscaArtista);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "MenuCanciones";
            this.Text = "Menú Canciones";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBuscaArtista;
        private System.Windows.Forms.Button btnBuscaPlaylist;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}