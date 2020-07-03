using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPoo2020
{
    public class Medico : Persona
    {
        private int puntosExp;

        public Medico(string nombre, int edad, string nacion, int sueldo, int puntosExp)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.nacion = nacion;
            this.sueldo = sueldo;
            this.puntosExp = puntosExp;

        }

        public bool Evaluar(Jugador player)
        {
            if (player.Injured)
            {
                return true;

            }
            return false;
        }

        public string Curar(Jugador player)
        {
            string estado = null;
            if (Evaluar(player))
            {
                estado = "El jugador ha sido curado";
            }
            return estado;

        }


    }
}
