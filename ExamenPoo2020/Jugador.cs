using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPoo2020
{
    public class Jugador : Persona
    {
        private int puntosATK;
        private int puntosDEF;
        private int numeroCamiseta;
        private bool injured = false;

        public int PuntosATK { get => puntosATK; }
        public int PuntosDEF { get => puntosDEF; }
        public int NumeroCamiseta { get => numeroCamiseta; }
        public bool Injured { get => injured; set => injured = value; }

        public delegate void LesionarJugadorEventHandler(object source, JugadorEventArgs args);
        public event LesionarJugadorEventHandler JugadorLesionado;

        public Jugador(string nombre, int edad, string nacion, int sueldo, int puntosATK, int puntosDEF, int numeroCamiseta)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.nacion = nacion;
            this.sueldo = sueldo;
            this.puntosATK = puntosATK;
            this.puntosDEF = puntosDEF;
            this.numeroCamiseta = numeroCamiseta;

        }

        protected virtual void OnJugadorLesionado(string name, int numeroC)
        {
            if(JugadorLesionado != null)
            {
                JugadorLesionado(this, new JugadorEventArgs() { Nombre = name, NumeroC = numeroC  });
            }
        }
    }
}
