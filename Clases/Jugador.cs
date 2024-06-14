using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle
{
    public class Jugador
    {
        public int id;
        public string nombre_jugador;
        public int partidas_ganadas;

        public Jugador(int id, string nombre_jugador, int partidas_ganadas)
        {
            this.id = id;
            this.nombre_jugador = nombre_jugador;
            this.partidas_ganadas = partidas_ganadas;
        }
        public Jugador(string nombre_jugador)
        {
            this.id = -1;
            this.nombre_jugador = nombre_jugador;
            this.partidas_ganadas = 0;
        }

        public Jugador obtener_o_registrar()
        {
            //Crear el archivo si no existe y buscar el jugador a registrar
            Jugador jugador = get_jugador_por_nombre(nombre_jugador);

            //Jugador no encontrado
            if (jugador != null)
            {
                return jugador;
            }

            //Para crear el jugador, primero obtener el máximo id y sumarle 1
            int nuevo_id = getMaxId() + 1 == 0 ? 1 : getMaxId() + 1;

            //Abrir el archivo en modo de concatenación y de escritura
            FileStream fs = new FileStream("jugador.txt", FileMode.Append, FileAccess.Write);

            //Abrir el escritor de texto
            StreamWriter writer = new StreamWriter(fs);

            //Establecer los valores del jugador a crearse
            this.id = nuevo_id;            
            this.partidas_ganadas = 0;

            //Escribir los datos del jugador (id, nombre_jugador, partidas_ganadas)
            writer.WriteLine(this.ToString());


            //Cerrar el archivo
            writer.Close();
            fs.Close();

            return this;
        }
        public bool modificar_jugador()
        {
            //Crear el archivo si no existe y buscar el jugador a registrar
            bool jugador_encontrado = existe_jugador_id(this.id);

            //Jugador no encontrado
            if (!jugador_encontrado) return false;

            //Obtener todos los jugadores registrados
            List<Jugador> lstjugadores = listar_jugadores();

            //Sobreescribir todo el archivo
            //Abrir el archivo en modo de escritura
            FileStream fs = new FileStream("jugador.txt", FileMode.OpenOrCreate, FileAccess.Write);

            //Abrir el escritor de texto
            StreamWriter writer = new StreamWriter(fs);

            //Escribir los datos de los jugadores
            for (int i = 0; i < lstjugadores.Count; i++)
            {
                if (this.id == lstjugadores[i].id)
                {
                    lstjugadores[i].nombre_jugador = this.nombre_jugador;
                    lstjugadores[i].partidas_ganadas = this.partidas_ganadas;
                }

                //Escribir los datos incluido el jugador modificado
                writer.WriteLine(lstjugadores[i].ToString());
            }

            //Cerrar el archivo
            writer.Close();
            fs.Close();

            return true;
        }
        private int getMaxId()
        {
            int id = -1;
            FileStream fs = new FileStream("jugador.txt", FileMode.OpenOrCreate, FileAccess.Read);

            StreamReader reader = new StreamReader(fs);
            string linea = string.Empty;

            while ((linea = reader.ReadLine()) != null)
            {
                string[] vector = linea.Split(',');

                id = int.Parse(vector[0]);
            }

            reader.Close();
            fs.Close();
            return id;
        }
        private List<Jugador> listar_jugadores()
        {
            List<Jugador> lstJugadorModel = new List<Jugador>();
            FileStream fs = new FileStream("jugador.txt", FileMode.OpenOrCreate, FileAccess.Read);

            StreamReader reader = new StreamReader(fs);
            string linea = string.Empty;

            while ((linea = reader.ReadLine()) != null)
            {
                string[] vector = linea.Split(',');

                int id_jugador = int.Parse(vector[0]);
                string nombre_jugador = vector[1];
                int partidas_ganadas = int.Parse(vector[2]);

                Jugador jugador = new Jugador(id_jugador, nombre_jugador, partidas_ganadas);
                lstJugadorModel.Add(jugador);
            }

            reader.Close();
            fs.Close();
            return lstJugadorModel;
        }
        public static Jugador get_jugador_por_nombre(string nombre)
        {
            Jugador jugador = null;
            FileStream fs = new FileStream("jugador.txt", FileMode.OpenOrCreate, FileAccess.Read);

            StreamReader reader = new StreamReader(fs);
            string linea = string.Empty;

            while ((linea = reader.ReadLine()) != null)
            {
                string[] vector = linea.Split(',');

                string nombre_jugador = vector[1];

                if (nombre_jugador == nombre)
                {
                    int id_jugador = int.Parse(vector[0]);                    
                    int partidas_ganadas = int.Parse(vector[2]);

                    jugador = new Jugador(id_jugador, nombre_jugador, partidas_ganadas);
                    break;
                }
            }

            //Cerrar archivo
            reader.Close();
            fs.Close();

            return jugador;
        }
        private bool existe_jugador_id(int id)
        {
            bool encontrado = false;
            FileStream fs = new FileStream("jugador.txt", FileMode.OpenOrCreate, FileAccess.Read);

            StreamReader reader = new StreamReader(fs);
            string linea = string.Empty;

            while ((linea = reader.ReadLine()) != null)
            {
                string[] vector = linea.Split(',');

                int id_jugador = int.Parse(vector[0]);

                if (id_jugador == id)
                {
                    encontrado = true;
                    break;
                }
            }

            //Cerrar archivo
            reader.Close();
            fs.Close();

            return encontrado;
        }
        public override string ToString()
        {
            return $"{id},{nombre_jugador},{partidas_ganadas}";
        }
    }
}
