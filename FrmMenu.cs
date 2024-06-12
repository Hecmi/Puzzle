using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("No ha ingresado su nombre de jugador (nickname)", "Puzzle", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Registrar el jugador en caso de que no exista
            Jugador jugador = new Jugador(txtUsuario.Text);
            jugador = jugador.registrar_jugador();

            FrmJuego frmJuego = new FrmJuego(jugador);
            frmJuego.Show();

            this.Hide();
        }
    }
}
