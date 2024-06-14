using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle
{
    public partial class FrmMenu : Form
    {
        public static FrmMenu frmMenu;
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Validar que el usuario haya ingresado caracteres
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("No ha ingresado su nombre de jugador (nickname)", "Puzzle", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Validar que el nombre de usuario no contenga caracteres especiales
            Regex regex_caracteres_validos = new Regex("^[a-zA-Z0-9 ]*$");
            if (!regex_caracteres_validos.IsMatch(txtUsuario.Text))
            {
                MessageBox.Show("El nombre de usuario no puede contener caracteres especiales", "Puzzle", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Registrar el jugador en caso de que no exista
            Jugador jugador = new Jugador(txtUsuario.Text);
            jugador = jugador.obtener_o_registrar();

            FrmJuego frmJuego = new FrmJuego(jugador);
            frmJuego.Show();

            this.Hide();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            //Singleton (Una única instancia del menú)
            frmMenu = this;
        }

        private void pnlInicio_Paint(object sender, PaintEventArgs e)
        {
            //Definir los parámetros de dibujo pará las líneas
            Color color_borde = Color.FromArgb(200, 200, 200);

            //Lapices para dibujar los bordes (aumentar uno a la izquierda y abajo por que pinta mal windows forms (? )
            Pen lapiz_tl = new Pen(color_borde, 1);
            Pen lapiz_dr = new Pen(color_borde, 2);

            //Obtener el espacio que ocupa el control
            Rectangle rect = ((Control)(sender)).ClientRectangle;

            //Dibujar la línea superior del control
            e.Graphics.DrawLine(lapiz_tl, rect.Left, rect.Top, rect.Right, rect.Top);            
        }
    }
}
