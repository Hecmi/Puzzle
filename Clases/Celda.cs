using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle
{
    class Celda
    {
        private int indice;
        private Image img;
        public int Indice { get { return indice; } }
        public Image Img { get { return img; } }

        public Celda(int indice, Image img)
        {
            this.indice = indice;
            this.img = img;
        }
    }
}
