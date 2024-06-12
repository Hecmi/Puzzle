
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
            this.dgvImagen = new System.Windows.Forms.DataGridView();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.btnImagen = new System.Windows.Forms.Button();
            this.cmbDimension = new System.Windows.Forms.ComboBox();
            this.pnlDatosJugador = new System.Windows.Forms.Panel();
            this.lblJugador = new System.Windows.Forms.Label();
            this.txtJugador = new System.Windows.Forms.TextBox();
            this.lblDimension = new System.Windows.Forms.Label();
            this.btnJugar = new System.Windows.Forms.Button();
            this.pnlJuego = new System.Windows.Forms.Panel();
            this.lblPartidasGanadas = new System.Windows.Forms.Label();
            this.lblNumPartidasGanadas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagen)).BeginInit();
            this.pnlOpciones.SuspendLayout();
            this.pnlDatosJugador.SuspendLayout();
            this.pnlJuego.SuspendLayout();
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
            this.dgvImagen.Location = new System.Drawing.Point(0, 0);
            this.dgvImagen.Name = "dgvImagen";
            this.dgvImagen.ReadOnly = true;
            this.dgvImagen.Size = new System.Drawing.Size(515, 450);
            this.dgvImagen.TabIndex = 0;
            this.dgvImagen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvImagen_KeyDown);
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.Controls.Add(this.btnImagen);
            this.pnlOpciones.Controls.Add(this.cmbDimension);
            this.pnlOpciones.Controls.Add(this.pnlDatosJugador);
            this.pnlOpciones.Controls.Add(this.lblJugador);
            this.pnlOpciones.Controls.Add(this.txtJugador);
            this.pnlOpciones.Controls.Add(this.lblDimension);
            this.pnlOpciones.Controls.Add(this.btnJugar);
            this.pnlOpciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlOpciones.Location = new System.Drawing.Point(515, 0);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(285, 450);
            this.pnlOpciones.TabIndex = 1;
            // 
            // btnImagen
            // 
            this.btnImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagen.Location = new System.Drawing.Point(23, 341);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(242, 40);
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
            this.cmbDimension.Location = new System.Drawing.Point(135, 24);
            this.cmbDimension.Name = "cmbDimension";
            this.cmbDimension.Size = new System.Drawing.Size(130, 26);
            this.cmbDimension.TabIndex = 8;
            // 
            // pnlDatosJugador
            // 
            this.pnlDatosJugador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDatosJugador.Controls.Add(this.lblNumPartidasGanadas);
            this.pnlDatosJugador.Controls.Add(this.lblPartidasGanadas);
            this.pnlDatosJugador.Location = new System.Drawing.Point(23, 109);
            this.pnlDatosJugador.Name = "pnlDatosJugador";
            this.pnlDatosJugador.Size = new System.Drawing.Size(242, 68);
            this.pnlDatosJugador.TabIndex = 6;
            // 
            // lblJugador
            // 
            this.lblJugador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJugador.AutoSize = true;
            this.lblJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugador.Location = new System.Drawing.Point(19, 67);
            this.lblJugador.Name = "lblJugador";
            this.lblJugador.Size = new System.Drawing.Size(71, 20);
            this.lblJugador.TabIndex = 5;
            this.lblJugador.Text = "Jugador:";
            // 
            // txtJugador
            // 
            this.txtJugador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJugador.Location = new System.Drawing.Point(135, 63);
            this.txtJugador.Name = "txtJugador";
            this.txtJugador.Size = new System.Drawing.Size(130, 24);
            this.txtJugador.TabIndex = 4;
            // 
            // lblDimension
            // 
            this.lblDimension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnJugar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugar.Location = new System.Drawing.Point(23, 387);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(242, 40);
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
            this.pnlJuego.Size = new System.Drawing.Size(515, 450);
            this.pnlJuego.TabIndex = 2;
            // 
            // lblPartidasGanadas
            // 
            this.lblPartidasGanadas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPartidasGanadas.AutoSize = true;
            this.lblPartidasGanadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartidasGanadas.Location = new System.Drawing.Point(14, 23);
            this.lblPartidasGanadas.Name = "lblPartidasGanadas";
            this.lblPartidasGanadas.Size = new System.Drawing.Size(137, 20);
            this.lblPartidasGanadas.TabIndex = 10;
            this.lblPartidasGanadas.Text = "Partidas ganadas:";
            // 
            // lblNumPartidasGanadas
            // 
            this.lblNumPartidasGanadas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumPartidasGanadas.AutoSize = true;
            this.lblNumPartidasGanadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPartidasGanadas.Location = new System.Drawing.Point(212, 23);
            this.lblNumPartidasGanadas.Name = "lblNumPartidasGanadas";
            this.lblNumPartidasGanadas.Size = new System.Drawing.Size(18, 20);
            this.lblNumPartidasGanadas.TabIndex = 11;
            this.lblNumPartidasGanadas.Text = "0";
            // 
            // FrmJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlJuego);
            this.Controls.Add(this.pnlOpciones);
            this.Name = "FrmJuego";
            this.Text = "Puzzle";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagen)).EndInit();
            this.pnlOpciones.ResumeLayout(false);
            this.pnlOpciones.PerformLayout();
            this.pnlDatosJugador.ResumeLayout(false);
            this.pnlDatosJugador.PerformLayout();
            this.pnlJuego.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvImagen;
        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.Panel pnlJuego;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Label lblDimension;
        private System.Windows.Forms.Label lblJugador;
        private System.Windows.Forms.TextBox txtJugador;
        private System.Windows.Forms.Panel pnlDatosJugador;
        private System.Windows.Forms.ComboBox cmbDimension;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.Label lblNumPartidasGanadas;
        private System.Windows.Forms.Label lblPartidasGanadas;
    }
}

