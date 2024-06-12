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
    public partial class Form1 : Form
    {
        Partida partida;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Configuración del datagridview
            dgvImagen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvImagen.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvImagen.ColumnHeadersVisible = false;
            dgvImagen.RowHeadersVisible = false;

            int dimension = 3;

            string ruta = string.Empty;
            OpenFileDialog fileDialog = new OpenFileDialog();
            Image img = null;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                ruta = fileDialog.FileName;
            }

            if (!string.IsNullOrEmpty(ruta))
            {
                img = Image.FromStream(new FileStream(ruta, FileMode.Open, FileAccess.Read));
            }

            partida = new Partida(dimension, img);

            for (int i = 0; i < dimension; i++)
            {
                DataGridViewImageColumn columnaPictureBox = new DataGridViewImageColumn();
                columnaPictureBox.ImageLayout = DataGridViewImageCellLayout.Stretch; 
                dgvImagen.Columns.Add(columnaPictureBox);

            }

            //Cargar las imágenes
            for (int i = 0; i < dimension; i++)
            {
                dgvImagen.Rows.Add();
                for (int j = 0; j < dimension; j++)
                {
                    dgvImagen.BackgroundColor = Color.White;
                    dgvImagen.Rows[i].Cells[j].Value = partida.Celdas[i, j].Img;
                }
            }
        }


        private void dgvImagen_KeyDown(object sender, KeyEventArgs e)
        {
            bool existe_cambio = false;
            int x1 = partida.Indice_Celda_Control[0];
            int y1 = partida.Indice_Celda_Control[1];

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
                int x2 = partida.Indice_Celda_Control[0];
                int y2 = partida.Indice_Celda_Control[1];

                intercambiar(x1, y1, x2, y2);
            }
        }

        private void intercambiar(int x1, int y1, int x2, int y2)
        {
            object temp = dgvImagen.Rows[x1].Cells[y1].Value;
            dgvImagen.Rows[x1].Cells[y1].Value = dgvImagen.Rows[x2].Cells[y2].Value;
            dgvImagen.Rows[x2].Cells[y2].Value = temp;
        }
    }
}
