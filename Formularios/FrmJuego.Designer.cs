
namespace Puzzle
{
    partial class FrmJuego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJuego));
            this.dgvImagen = new System.Windows.Forms.DataGridView();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.btnImagen = new System.Windows.Forms.Button();
            this.cmbDimension = new System.Windows.Forms.ComboBox();
            this.lblNumPartidasGanadas = new System.Windows.Forms.Label();
            this.lblPartidasGanadas = new System.Windows.Forms.Label();
            this.lblNombreJugador = new System.Windows.Forms.Label();
            this.lblDimension = new System.Windows.Forms.Label();
            this.btnJugar = new System.Windows.Forms.Button();
            this.pnlJuego = new System.Windows.Forms.Panel();
            this.lblImagenSeleccionada = new System.Windows.Forms.Label();
            this.cmbModo = new System.Windows.Forms.ComboBox();
            this.lblModo = new System.Windows.Forms.Label();
            this.lblJugador = new System.Windows.Forms.Label();
            this.pbImagenSeleccionada = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagen)).BeginInit();
            this.pnlOpciones.SuspendLayout();
            this.pnlJuego.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenSeleccionada)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvImagen
            // 
            this.dgvImagen.AllowUserToAddRows = false;
            this.dgvImagen.AllowUserToDeleteRows = false;
            this.dgvImagen.AllowUserToResizeColumns = false;
            this.dgvImagen.AllowUserToResizeRows = false;
            this.dgvImagen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvImagen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvImagen.Location = new System.Drawing.Point(5, 5);
            this.dgvImagen.Name = "dgvImagen";
            this.dgvImagen.ReadOnly = true;
            this.dgvImagen.Size = new System.Drawing.Size(485, 481);
            this.dgvImagen.TabIndex = 0;
            this.dgvImagen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvImagen_KeyDown);
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.Controls.Add(this.lblNumPartidasGanadas);
            this.pnlOpciones.Controls.Add(this.cmbModo);
            this.pnlOpciones.Controls.Add(this.lblPartidasGanadas);
            this.pnlOpciones.Controls.Add(this.lblModo);
            this.pnlOpciones.Controls.Add(this.lblJugador);
            this.pnlOpciones.Controls.Add(this.lblImagenSeleccionada);
            this.pnlOpciones.Controls.Add(this.pbImagenSeleccionada);
            this.pnlOpciones.Controls.Add(this.btnImagen);
            this.pnlOpciones.Controls.Add(this.cmbDimension);
            this.pnlOpciones.Controls.Add(this.lblNombreJugador);
            this.pnlOpciones.Controls.Add(this.lblDimension);
            this.pnlOpciones.Controls.Add(this.btnJugar);
            this.pnlOpciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlOpciones.Location = new System.Drawing.Point(495, 0);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(339, 491);
            this.pnlOpciones.TabIndex = 1;
            this.pnlOpciones.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOpciones_Paint);
            // 
            // btnImagen
            // 
            this.btnImagen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagen.Location = new System.Drawing.Point(23, 382);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(296, 40);
            this.btnImagen.TabIndex = 9;
            this.btnImagen.Text = "Seleccionar imágen";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // cmbDimension
            // 
            this.cmbDimension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDimension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDimension.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDimension.FormattingEnabled = true;
            this.cmbDimension.Location = new System.Drawing.Point(189, 24);
            this.cmbDimension.Name = "cmbDimension";
            this.cmbDimension.Size = new System.Drawing.Size(130, 26);
            this.cmbDimension.TabIndex = 8;
            // 
            // lblNumPartidasGanadas
            // 
            this.lblNumPartidasGanadas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumPartidasGanadas.AutoSize = true;
            this.lblNumPartidasGanadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPartidasGanadas.Location = new System.Drawing.Point(301, 128);
            this.lblNumPartidasGanadas.Name = "lblNumPartidasGanadas";
            this.lblNumPartidasGanadas.Size = new System.Drawing.Size(18, 20);
            this.lblNumPartidasGanadas.TabIndex = 11;
            this.lblNumPartidasGanadas.Text = "0";
            this.lblNumPartidasGanadas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPartidasGanadas
            // 
            this.lblPartidasGanadas.AutoSize = true;
            this.lblPartidasGanadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartidasGanadas.Location = new System.Drawing.Point(19, 128);
            this.lblPartidasGanadas.Name = "lblPartidasGanadas";
            this.lblPartidasGanadas.Size = new System.Drawing.Size(137, 20);
            this.lblPartidasGanadas.TabIndex = 10;
            this.lblPartidasGanadas.Text = "Partidas ganadas:";
            // 
            // lblNombreJugador
            // 
            this.lblNombreJugador.AutoSize = true;
            this.lblNombreJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreJugador.Location = new System.Drawing.Point(19, 92);
            this.lblNombreJugador.Name = "lblNombreJugador";
            this.lblNombreJugador.Size = new System.Drawing.Size(71, 20);
            this.lblNombreJugador.TabIndex = 5;
            this.lblNombreJugador.Text = "Jugador:";
            // 
            // lblDimension
            // 
            this.lblDimension.AutoSize = true;
            this.lblDimension.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDimension.Location = new System.Drawing.Point(19, 28);
            this.lblDimension.Name = "lblDimension";
            this.lblDimension.Size = new System.Drawing.Size(88, 20);
            this.lblDimension.TabIndex = 3;
            this.lblDimension.Text = "Dimensión:";
            // 
            // btnJugar
            // 
            this.btnJugar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugar.Location = new System.Drawing.Point(23, 428);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(296, 40);
            this.btnJugar.TabIndex = 0;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // pnlJuego
            // 
            this.pnlJuego.Controls.Add(this.dgvImagen);
            this.pnlJuego.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlJuego.Location = new System.Drawing.Point(0, 0);
            this.pnlJuego.Name = "pnlJuego";
            this.pnlJuego.Padding = new System.Windows.Forms.Padding(5);
            this.pnlJuego.Size = new System.Drawing.Size(495, 491);
            this.pnlJuego.TabIndex = 2;
            // 
            // lblImagenSeleccionada
            // 
            this.lblImagenSeleccionada.AutoSize = true;
            this.lblImagenSeleccionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagenSeleccionada.Location = new System.Drawing.Point(19, 177);
            this.lblImagenSeleccionada.Name = "lblImagenSeleccionada";
            this.lblImagenSeleccionada.Size = new System.Drawing.Size(164, 20);
            this.lblImagenSeleccionada.TabIndex = 11;
            this.lblImagenSeleccionada.Text = "Imagen seleccionada:";
            // 
            // cmbModo
            // 
            this.cmbModo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbModo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModo.FormattingEnabled = true;
            this.cmbModo.Location = new System.Drawing.Point(189, 56);
            this.cmbModo.Name = "cmbModo";
            this.cmbModo.Size = new System.Drawing.Size(130, 26);
            this.cmbModo.TabIndex = 13;
            // 
            // lblModo
            // 
            this.lblModo.AutoSize = true;
            this.lblModo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModo.Location = new System.Drawing.Point(19, 62);
            this.lblModo.Name = "lblModo";
            this.lblModo.Size = new System.Drawing.Size(122, 20);
            this.lblModo.TabIndex = 12;
            this.lblModo.Text = "Modo de juego: ";
            // 
            // lblJugador
            // 
            this.lblJugador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugador.Location = new System.Drawing.Point(192, 92);
            this.lblJugador.Name = "lblJugador";
            this.lblJugador.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblJugador.Size = new System.Drawing.Size(127, 20);
            this.lblJugador.TabIndex = 12;
            this.lblJugador.Text = "Nombre Jugador";
            this.lblJugador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbImagenSeleccionada
            // 
            this.pbImagenSeleccionada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImagenSeleccionada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbImagenSeleccionada.Location = new System.Drawing.Point(23, 211);
            this.pbImagenSeleccionada.Name = "pbImagenSeleccionada";
            this.pbImagenSeleccionada.Size = new System.Drawing.Size(296, 146);
            this.pbImagenSeleccionada.TabIndex = 10;
            this.pbImagenSeleccionada.TabStop = false;
            // 
            // FrmJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 491);
            this.Controls.Add(this.pnlJuego);
            this.Controls.Add(this.pnlOpciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(850, 530);
            this.Name = "FrmJuego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puzzle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmJuego_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.FrmJuego_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagen)).EndInit();
            this.pnlOpciones.ResumeLayout(false);
            this.pnlOpciones.PerformLayout();
            this.pnlJuego.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenSeleccionada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvImagen;
        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.Panel pnlJuego;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Label lblDimension;
        private System.Windows.Forms.Label lblNombreJugador;
        private System.Windows.Forms.ComboBox cmbDimension;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.Label lblNumPartidasGanadas;
        private System.Windows.Forms.Label lblPartidasGanadas;
        private System.Windows.Forms.PictureBox pbImagenSeleccionada;
        private System.Windows.Forms.Label lblImagenSeleccionada;
        private System.Windows.Forms.ComboBox cmbModo;
        private System.Windows.Forms.Label lblModo;
        private System.Windows.Forms.Label lblJugador;
    }
}

