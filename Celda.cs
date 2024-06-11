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
        public int Indice { get; set; }
        public Image Img { get; set; }

        public Celda(int indice, Image img)
        {
            this.Indice = indice;
            this.Img = img;
        }
    }
}
