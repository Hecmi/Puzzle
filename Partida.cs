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
        Celda[,] celdas;
        int [] pos_celda_control;

        int dimension;
        bool partida_finalizada;

        public Celda[,] Celdas { get { return celdas; } }
        public int [] Pos_celda_control{ get { return pos_celda_control; } }
        public bool Partida_finalizada { get { return partida_finalizada; } }

        public Partida(int dimension, Image img)
        {            
            this.dimension = dimension;
            this.celdas = new Celda[dimension, dimension];

            pos_celda_control = new int[2];
            partida_finalizada = false;

            generarPartida(img);
            //mezclarCeldas();
        }

        private void generarPartida(Image img)
        {
            bool imagen_nula = img == null;

            //Procesar la imagen por si es nula
            img = procesarImagen(img);

            //Obtener las dimensiones de la imagen
            int alto_img = img.Height;
            int ancho_img = img.Width;

            //Calcular las dimensiones de cada celda
            int alto = alto_img / dimension;
            int ancho = ancho_img / dimension;

            int contador = 0;
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    Image img_cortada;

                    string texto_imagen = imagen_nula ? (contador + 1).ToString() : string.Empty;
                    img_cortada = cortarImagen(img, j * ancho, i * alto, ancho, alto, texto_imagen);

                    //Crear el nuevo objeto de tipo celda
                    celdas[i, j] = new Celda(contador, img_cortada);
                    contador++;
                }
            }

            //A la última celda eliminar los valores que le fueron asignados
            pos_celda_control[0] = dimension - 1;
            pos_celda_control[1] = dimension - 1;

            //Redefinir los valores de la última celda 
            Bitmap bm = new Bitmap(ancho, alto);
            Graphics g = Graphics.FromImage(bm);
            g.Clear(Color.White);

            Celda celda_control = celdas[dimension - 1, dimension - 1];
            celda_control.Img = bm;
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

            //Verificar si los índices equivalen a la celda que esta vacía (control)
            if (x1 == pos_celda_control[0] && y1 == pos_celda_control[1])
            {
                pos_celda_control[0] = x2;
                pos_celda_control[1] = y2;
            }
            else if (x2 == pos_celda_control[0] && y2 == pos_celda_control[1])
            {
                pos_celda_control[0] = x1;
                pos_celda_control[1] = y1;
            }

            return true;
        }

        public void mezclarCeldas()
        {
            //Generar números aleatorios la misma cantidad de celdas existentes
            //para mantener una misma distribución de probabilidad
            Random rnd = new Random(Environment.TickCount);
            for (int i = 0; i < dimension * dimension; i++)
            {
                //Generación de índices para la primera posición de la matriz
                int x1 = rnd.Next(0, dimension);
                int y1 = rnd.Next(0, dimension);

                //Generación de índices para la segunda posición de la matriz
                int x2 = rnd.Next(0, dimension);
                int y2 = rnd.Next(0, dimension);

                intercambiar(x1, y1, x2, y2);
            }
        }

        private Image procesarImagen(Image img)
        {
            Bitmap img_procesada = null;

            if (img == null)
            {                
                //Sí la imágen es nula, definir una imágen blanca con un tamaño
                //predeterminado
                img_procesada = new Bitmap(720, 720);

                //Definir el color de la imágen
                Graphics graphics = Graphics.FromImage(img_procesada);
                graphics.Clear(Color.White);
            }
            else
            {
                //int nueva_altura;
                //int nuevo_ancho;
                //if (img.Width > img.Height)
                //{
                //    nuevo_ancho = 750;
                //    nueva_altura = (int)((float)img.Height / img.Width * 750);
                //}
                //else
                //{
                //    nuevo_ancho = (int)((float)img.Width / img.Height * 750);
                //    nueva_altura = 750;
                //}

                //Rescalar la imagen                
                img_procesada = new Bitmap(img, new Size(240, 240));
            }

            return img_procesada;
        }       
        private Image cortarImagen(Image img, int x, int y, int ancho, int alto, string texto)
        {
            //Crear un mapa de bits del ancho y alto determinado para la celda
            Bitmap imagen_cortada = new Bitmap(ancho, alto);
            Graphics graphics = Graphics.FromImage(imagen_cortada);
           
            //Establecer el punto donde empieza y termina la imágen recortada
            Rectangle origen = new Rectangle(x, y, ancho, alto);
            Rectangle destino = new Rectangle(0, 0, ancho, alto);

            //Fuente y ubicación para el texto a definirse en la imágen
            Font font = new Font("Arial", 14);
            SizeF tamanio_texto = graphics.MeasureString(texto, font);
            PointF ubicacion_texto = new PointF((ancho - tamanio_texto.Width) / 2, (alto - tamanio_texto.Height) / 2);

            //Dibujar la imágen y el texto correspondiente
            graphics.DrawImage(img, destino, origen, GraphicsUnit.Pixel);
            graphics.DrawString(texto, font, Brushes.Black, ubicacion_texto);

            return imagen_cortada;
        }
        public bool moverArriba()
        {
            bool intercambio = false;
            //Verificar si se pude mover hacia arriba
            if (pos_celda_control[0] > 0)
            {
                intercambio = intercambiar(pos_celda_control[0], pos_celda_control[1], pos_celda_control[0] - 1, pos_celda_control[1]);
                verificarEstado();
            }

            return intercambio;
        }
        public bool moverAbajo()
        {
            bool intercambio = false;
            //Verificar si se pude mover hacia abajo
            if (pos_celda_control[0] < dimension - 1)
            {
                intercambio = intercambiar(pos_celda_control[0], pos_celda_control[1], pos_celda_control[0] + 1, pos_celda_control[1]);
                verificarEstado();
            }

            return intercambio;
        }
        public bool moverIzquierda()
        {
            bool intercambio = false;
            //Verificar si se pude mover hacia la izquierda
            if (pos_celda_control[1] > 0)
            {
                intercambio = intercambiar(pos_celda_control[0], pos_celda_control[1], pos_celda_control[0], pos_celda_control[1] - 1);
                verificarEstado();
            }

            return intercambio;
        }
        public bool moverDerecha()
        {
            bool intercambio = false;
            //Verificar si se pude mover hacia la derecha
            if (pos_celda_control[1] < dimension - 1)
            {
                intercambio =  intercambiar(pos_celda_control[0], pos_celda_control[1], pos_celda_control[0], pos_celda_control[1] + 1);
                verificarEstado();
            }

            return intercambio;
        }
        private bool verificarEstado()
        {
            int contador = 0;

            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    //Sí llega a la última posición de la matriz significa que está ordenada
                    //y por lo tanto ganó el juego
                    if (i == dimension - 1 && j == dimension - 1)
                    {
                        partida_finalizada = true;
                        return partida_finalizada;
                    }

                    if (celdas[i, j].Indice != contador)
                    {
                        return false;
                    }

                    contador++;
                }
            }

            return partida_finalizada;
        }
    }
}
