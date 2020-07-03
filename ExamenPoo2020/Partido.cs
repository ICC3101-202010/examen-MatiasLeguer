using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPoo2020
{
    public class Partido
    {

        private Equipo equipo1;
        private Equipo equipo2;
        private int duracionPartido;

        public Equipo Equipo1 { get => equipo1; set => equipo1 = value; }
        public Equipo Equipo2 { get => equipo2; set => equipo2 = value; }
        public int DuracionPartido { get; set; }

        public Partido(Equipo equipo1, Equipo equipo2)
        {
            this.equipo1 = equipo1;
            this.equipo2 = equipo2;
        }

        public void JugarPartido()
        {
            if (CheckNacionalidadEquipos())
            {
                Console.WriteLine("Comienza el partido");
            }
            else
            {
                Console.WriteLine("No se puede jugar el partido");
            }
        }

        public bool CheckNacionalidadEquipos()
        {
            if ((equipo1.EsNacional == true && equipo2.EsNacional == true) || (equipo1.EsNacional == false && equipo2.EsNacional == false))
            {
                return true;
            }
            return false;
        }

        public string MostrarInfoPartido()
        {
            string infoPartido = "Los Equipos que estan participando en el partido son los siguientes:\n\nEquipo1: " + equipo1.NombreEquipo + "\tEquipo2: " + equipo2.NombreEquipo;
            infoPartido += "\n\n Tiempo de duración del partido: " + duracionPartido.ToString();
            infoPartido += "\n\n Resultado Partido: \n" + equipo1.NombreEquipo + " " + equipo1.Puntaje + " - " + equipo2.NombreEquipo + " " + equipo2.Puntaje;
            infoPartido += "\n\nPartido de tipo: ";

            if (equipo1.EsNacional)
            {
                infoPartido += "Nacional";
            }
            else
            {
                infoPartido += "Liga";
            }
            return infoPartido;
        }

        public void OnJugadorCambiado(object sender, JugadorEventArgs e)
        {
            Console.WriteLine("Se ha cambiado el jugador {0} por el jugador {1}, sus respectivos numeros son {2} y {3}", e.Nombre, e.NombreNew, e.NumeroC, e.NumeroCNew);
        }


    }
}
