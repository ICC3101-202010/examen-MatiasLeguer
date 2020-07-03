using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPoo2020
{
    public class Equipo
    {
        private string nombreEquipo;
        private bool esNacional;
        private string nacionalidad;
        private int puntaje;
        private List<Jugador> jugadores = new List<Jugador>(15);
        private Entrenador entrenador;
        private Medico medico;


        public string NombreEquipo { get => nombreEquipo; }
        public Entrenador Trainer { get => entrenador; set => entrenador = value; }
        public Medico Medico { get => medico; set => medico = value; }
        public bool EsNacional { get => esNacional; }
        public int Puntaje { get => puntaje; }

        public Equipo(string nombreEquipo, bool esNacional, string nacionalidad)
        {
            this.nombreEquipo = nombreEquipo;
            this.esNacional = esNacional;
            this.nacionalidad = nacionalidad;
            //JugadorLesionado += OnJugadorLesionado;  //Coloque la suscripción acá debido a que no se coloca nada en el program. Si no, lo hubiera colocado en el programa.
        }

        public bool AgregarJugador(Jugador player)
        {
            if (CheckNacionalidad(player.Nacion))
            {
                jugadores.Add(player);
                return true;
            }
            return false;
        }

        public bool CheckNacionalidad(string nacionalidadPlayer)
        {
            if (esNacional)
            {
                if(nacionalidad == nacionalidadPlayer)
                {
                    return true;
                }
                return false;

            }
            return false;

        }

        public string InformacionEquipo()
        {
            string infoEquipo = "INFORMACIÓN EQUIPO" + "\nNombre del equipo: " + nombreEquipo;

            if (esNacional)
            {
                infoEquipo += "\nNacionalidad: " + nacionalidad;
            }
            else
            {
                infoEquipo += "\nLiga: " + nacionalidad;
            }

            infoEquipo += "\n----------------------------\n"  + "\nEntrenador:\n" + "-----------------" + "\n\tNombre: " + entrenador.Nombre + "\n\tEdad: " + entrenador.Edad + "\n\tNacion: " + entrenador.Nacion + "\n\tSueldo: " + entrenador.Sueldo +"\n";
            infoEquipo += "\nMédico:\n" + "-----------------" + "\n\tNombre: " + medico.Nombre + "\n\tEdad: " + medico.Edad + "\n\tNacion: " + medico.Nacion + "\n\tSueldo: " + medico.Sueldo + "\n";

            infoEquipo += "\nJUGADORES";
            foreach (Jugador player in jugadores)
            {
                infoEquipo += "\nNombre: " + player.Nombre +"\tNúmero: " + player.NumeroCamiseta;
            }
            return infoEquipo;
        }

        public void OnJugadorLesionado(object sender, JugadorEventArgs e)
        {
            for(int i = 0; i < jugadores.Count(); i++)
            {
                if(jugadores[i].Nombre == e.Nombre && jugadores[i].NumeroCamiseta == e.NumeroC)
                {
                    if(i != jugadores.Count() - 1)
                    {
                        entrenador.OnJugadorCambiado(e.Nombre, e.NumeroC, jugadores[i + 1].Nombre, jugadores[i + 1].NumeroCamiseta);
                    }
                    else
                    {
                        entrenador.OnJugadorCambiado(e.Nombre, e.NumeroC, jugadores[0].Nombre, jugadores[0].NumeroCamiseta);
                    }
                    
                }
            }
        }

        public void GolEquipo()
        {
            puntaje++;
        }

    }
}
