using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle
{
    public partial class FrmJuego : Form
    {
        Jugador jugador;

        Partida partida;
        Image img;
        bool MOVER_CELDA;

        int dimension;
        public FrmJuego(Jugador jugador)
        {
            InitializeComponent();
            this.jugador = jugador;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Configuración del datagridview
            //Ocultar las los encabezados de filas y columnas
            dgvImagen.ColumnHeadersVisible = false;
            dgvImagen.RowHeadersVisible = false;

            dgvImagen.BackgroundColor = Color.White;
            dgvImagen.Enabled = false;

            MOVER_CELDA = true;

            //Cargar las opciones de dimensiones en el combobox
            for (int i = 4; i < 8; i++)
            {
                cmbDimension.Items.Add(i);
            }

            //Cargar los modos            
            cmbModo.Items.Add("Celda vacía");
            cmbModo.Items.Add("Vecinos a celda");

            //Colocar un valor por defecto en los combobox.
            cmbDimension.SelectedIndex = 0;
            cmbModo.SelectedIndex = 0;

            //Cargar los datos del jugador
            lblJugador.Text = jugador.nombre_jugador;
            lblNumPartidasGanadas.Text = jugador.partidas_ganadas.ToString();
        }


        private void dgvImagen_KeyDown(object sender, KeyEventArgs e)
        {
            bool existe_cambio = false;

            //Valores de la celda de control antes del cambio
            int x1 = partida.Pos_celda_control[0];
            int y1 = partida.Pos_celda_control[1];

            if (e.KeyValue == 38) //Arriba
            {
                existe_cambio = MOVER_CELDA ? partida.mover_arriba() : partida.mover_abajo();
            }
            else if (e.KeyValue == 40) //Abajo
            {
                existe_cambio = MOVER_CELDA ? partida.mover_abajo() : partida.mover_arriba();
            }
            else if (e.KeyValue == 37) //Izquierda
            {
                existe_cambio = MOVER_CELDA ? partida.mover_izquierda() : partida.mover_derecha();
            }
            else if (e.KeyValue == 39) //Derecha
            {
                existe_cambio = MOVER_CELDA ? partida.mover_derecha() : partida.mover_izquierda();
            }

            if (existe_cambio)
            {
                //Valores de la celda de control después del cambio
                int x2 = partida.Pos_celda_control[0];
                int y2 = partida.Pos_celda_control[1];

                //Intercambio de celdas en data grid view
                intercambiar(x1, y1, x2, y2);
            }

            if (partida.Partida_finalizada)
            {
                //Actualizar la cantida de victorias del jugador
                jugador.partidas_ganadas += 1;
                jugador.modificar_jugador();

                lblNumPartidasGanadas.Text = jugador.partidas_ganadas.ToString();

                dgvImagen.Enabled = false;
                MessageBox.Show("¡Felicidades, Usted ha ganado la partida!", "Puzzle", MessageBoxButtons.OK, MessageBoxIcon.Information);               
            }
        }

        private void intercambiar(int x1, int y1, int x2, int y2)
        {
            Image temp = (Image)dgvImagen.Rows[x1].Cells[y1].Value;
            dgvImagen.Rows[x1].Cells[y1].Value = dgvImagen.Rows[x2].Cells[y2].Value;
            dgvImagen.Rows[x2].Cells[y2].Value = temp;
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            //Activar el datagridview para realizar movimientos
            dgvImagen.Enabled = true;

            //Cargar los parámetros para la partida
            dimension = int.Parse(cmbDimension.SelectedItem.ToString());
            MOVER_CELDA = cmbModo.SelectedIndex == 0 ? true : false;

            //Crear la partida con los datos establecidos por el usuario
            partida = new Partida(dimension, img);

            cargarCeldasEnDgv(dimension);
        }
        private void btnImagen_Click(object sender, EventArgs e)
        {
            string ruta = string.Empty;
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*;*.bmp;*.svg|Archivos JPG (*.jpg;*.jpeg)|*.jpg;*.jpeg|Archivos BMP (*.bmp)|*.bmp|Archivos SVG (*.svg)|*.svg";
            img = null;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                ruta = fileDialog.FileName;
            }

            if (!string.IsNullOrEmpty(ruta))
            {
                img = Image.FromStream(new FileStream(ruta, FileMode.Open, FileAccess.Read));
                pbImagenSeleccionada.BackgroundImage = img;
            }
        }

        private void cargarCeldasEnDgv(int dimension)
        {
            //Reiniciar la cantidad de filas y columnas
            dgvImagen.RowCount = 0;
            dgvImagen.ColumnCount = 0;

            //Agregar n (dimension) columnas de tipo picturebox
            for (int i = 0; i < dimension; i++)
            {
                DataGridViewImageColumn columnaPictureBox = new DataGridViewImageColumn();
                columnaPictureBox.ImageLayout = DataGridViewImageCellLayout.Stretch;
                int indice_columna = dgvImagen.Columns.Add(columnaPictureBox);

                //Calcular el ancho de las columnas considerando las dimensiones
                dgvImagen.Columns[indice_columna].Width = dgvImagen.Width / dimension - 1;
            }

            //Agregar las filas en cada columna
            for (int i = 0; i < dimension; i++)
            {
                int indice_fila = dgvImagen.Rows.Add();

                //Calcular el alto de las filas considerando las dimensiones
                dgvImagen.Rows[indice_fila].Height = dgvImagen.Height / dimension - 1;
            }

            //Cargar las imágenes de la partida
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    dgvImagen.BackgroundColor = Color.White;
                    dgvImagen.Rows[i].Cells[j].Value = partida.Celdas[i, j].Img;
                }
            }
        }

        private void FrmJuego_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMenu.frmMenu.Show();
        }

        private void pnlOpciones_Paint(object sender, PaintEventArgs e)
        {
            //Definir los parámetros de dibujo pará las líneas
            Color color_borde = Color.FromArgb(200, 200, 200);

            //Lapices para dibujar los bordes (aumentar uno a la izquierda y abajo por que pinta mal windows forms (? )
            Pen lapiz_tl = new Pen(color_borde, 1);
            Pen lapiz_dr = new Pen(color_borde, 2);

            //Obtener el espacio que ocupa el control
            Rectangle rect = ((Control)(sender)).ClientRectangle;

            //Dibujar la línea derecha del control
            e.Graphics.DrawLine(lapiz_tl, rect.Left, rect.Top, rect.Left, rect.Bottom);
        }

        private void FrmJuego_Resize(object sender, EventArgs e)
        {
            cargarCeldasEnDgv(dimension);
        }
    }
}
