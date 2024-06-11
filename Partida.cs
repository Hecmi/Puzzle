using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle
{
    class Partida
    {
        int dimension;
        int [] indice_celda_control;

        Celda[,] celdas;
        public Celda[,] Celdas { get { return celdas; } }
        public int [] Indice_Celda_Control{ get { return indice_celda_control; } }

        public Partida(int dimension, Image img)
        {
            this.dimension = dimension;
            this.celdas = new Celda[dimension, dimension];

            indice_celda_control = new int[2];

            generarPartida(img);
            mezclarCeldas();
        }

        private void generarPartida(Image img)
        {
            int alto_img = img.Height;
            int ancho_img = img.Width;

            int alto = alto_img / dimension;
            int ancho = ancho_img / dimension;

            int contador = 0;
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {                    
                    Image img_cortada = cortarImagen(img, j * ancho, i * alto, ancho, alto);

                    //Crear el nuveo objeto de tipo celda
                    celdas[i, j] = new Celda(contador, img_cortada);
                    contador++;
                }
            }

            //A la última celda eliminar los valores que le fueron asignados
            indice_celda_control[0] = dimension - 1;
            indice_celda_control[1] = dimension - 1;

            Celda celda_control = celdas[dimension - 1, dimension - 1];
            celda_control.Img = null;
            celda_control.Indice = -1;
        }

        private bool intercambiar(int x1, int y1, int x2, int y2)
        {
            //Sí son iguales los índices, entonces no realizar le intercambio
            if (x1 == x2 && y1 == y2) return false;

            //Intercambiar las celdas correspondientes
            Celda temp = celdas[x1, y1];
            celdas[x1, y1] = celdas[x2, y2];
            celdas[x2, y2] = temp;

            //Verificar si los índices equivalen a la celda que esta vacía o que se controla
            if (x1 == indice_celda_control[0] && y1 == indice_celda_control[1])
            {
                indice_celda_control[0] = x2;
                indice_celda_control[1] = y2;
            }
            else if (x2 == indice_celda_control[0] && y2 == indice_celda_control[1])
            {
                indice_celda_control[0] = x1;
                indice_celda_control[1] = y1;
            }

            return true;
        }

        private void mezclarCeldas()
        {
            Random rnd = new Random(Environment.TickCount);
            for (int i = 0; i < dimension * dimension; i++)
            {
                int x1 = rnd.Next(0, dimension);
                int y1 = rnd.Next(0, dimension);

                int x2 = rnd.Next(0, dimension);
                int y2 = rnd.Next(0, dimension);

                intercambiar(x1, y1, x2, y2);
            }
        }

        private Image cortarImagen(Image img, int x, int y, int ancho, int alto)
        {
            Bitmap imagen_cortada = new Bitmap(ancho, alto);
            Graphics graphics = Graphics.FromImage(imagen_cortada);

            Rectangle origen = new Rectangle(x, y, ancho, alto);
            Rectangle destino = new Rectangle(0, 0, ancho, alto);

            graphics.DrawImage(img, destino, origen, GraphicsUnit.Pixel);

            return imagen_cortada;
        }

        public bool moverArriba()
        {
            bool intercambio = false;
            if (indice_celda_control[0] > 0)
            {
                intercambio = intercambiar(indice_celda_control[0], indice_celda_control[1], indice_celda_control[0] - 1, indice_celda_control[1]);
                verificarEstado();
            }

            return intercambio;
        }
        public bool moverAbajo()
        {
            bool intercambio = false;
            //Verificar si se pude mover hacia abajo
            if (indice_celda_control[0] < dimension - 1)
            {
                intercambio = intercambiar(indice_celda_control[0], indice_celda_control[1], indice_celda_control[0] + 1, indice_celda_control[1]);
                verificarEstado();
            }

            return intercambio;
        }
        public bool moverIzquierda()
        {
            bool intercambio = false;
            //Verificar si se pude mover hacia la izquierda
            if (indice_celda_control[1] > 0)
            {
                intercambio = intercambiar(indice_celda_control[0], indice_celda_control[1], indice_celda_control[0], indice_celda_control[1] - 1);
                verificarEstado();
            }

            return intercambio;
        }
        public bool moverDerecha()
        {
            bool intercambio = false;
            //Verificar si se pude mover hacia la derecha
            if (indice_celda_control[1] < dimension - 1)
            {
                intercambio =  intercambiar(indice_celda_control[0], indice_celda_control[1], indice_celda_control[0], indice_celda_control[1] + 1);
                verificarEstado();
            }

            return intercambio;
        }
        private bool verificarEstado()
        {
            int contador = 0;
            bool juego_finalizado = false;

            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    //Sí llega a la última posición de la matriz significa que está ordenada
                    //y por lo tanto ganó el juego
                    if (i == dimension - 1 && j == dimension - 1)
                    {
                        juego_finalizado = true;
                        continue;
                    }

                    if (celdas[i, j].Indice != contador)
                    {
                        return false;
                    }

                    contador++;
                }
            }

            if (juego_finalizado)
            {
                System.Windows.Forms.MessageBox.Show("Felicidades, ha finalizado el juego");
            }

            return juego_finalizado;
        }
    }
}
