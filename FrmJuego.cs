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

            //Cargar las opciones de dimensiones en el combobox
            for(int i = 4; i < 8; i++)
            {
                cmbDimension.Items.Add(i);
            }

            //Colocar un valor por defecto en el combobox.
            cmbDimension.SelectedIndex = 0;

            //Cargar los datos del jugador
            txtJugador.Text = jugador.nombre_jugador;
            lblNumPartidasGanadas.Text = jugador.partidas_ganadas.ToString();
        }


        private void dgvImagen_KeyDown(object sender, KeyEventArgs e)
        {
            bool existe_cambio = false;

            //Valores de la celda de control antes del cambio
            int x1 = partida.Pos_celda_control[0];
            int y1 = partida.Pos_celda_control[1];

            if (e.KeyValue == 38)
            {
                existe_cambio = partida.moverArriba();
            }
            else if (e.KeyValue == 40)
            {
                existe_cambio = partida.moverAbajo();
            }
            else if (e.KeyValue == 37)
            {
                existe_cambio = partida.moverIzquierda();
            }
            else if (e.KeyValue == 39)
            {
                existe_cambio = partida.moverDerecha();
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

            //Crear la partida con los datos establecidos por el usuario
            partida = new Partida(dimension, img);

            cargarCeldasEnDgv(dimension);

            //Cargar las imágenes
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    dgvImagen.BackgroundColor = Color.White;
                    dgvImagen.Rows[i].Cells[j].Value = partida.Celdas[i, j].Img;
                }
            }
        }

        private void btnMezclar_Click(object sender, EventArgs e)
        {
            partida.mezclarCeldas();
            //Cargar las imágenes
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    dgvImagen.BackgroundColor = Color.White;
                    dgvImagen.Rows[i].Cells[j].Value = partida.Celdas[i, j].Img;
                }
            }
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            string ruta = string.Empty;
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Archivos de imagen JPG (*.jpg)|*.jpg";
            img = null;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                ruta = fileDialog.FileName;
            }

            if (!string.IsNullOrEmpty(ruta))
            {
                img = Image.FromStream(new FileStream(ruta, FileMode.Open, FileAccess.Read));
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

            //Cargar las imágenes
            for (int i = 0; i < dimension; i++)
            {
                int indice_fila = dgvImagen.Rows.Add();

                //Calcular el alto de las filas considerando las dimensiones
                dgvImagen.Rows[indice_fila].Height = dgvImagen.Height / dimension - 1;
            }
        }
    }
}
