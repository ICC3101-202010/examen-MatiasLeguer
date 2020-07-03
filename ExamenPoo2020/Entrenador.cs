using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPoo2020
{
    public class Entrenador : Persona
    {
        private int puntosTactica;

        public delegate void CambiarJugadorEventHandler(object source, JugadorEventArgs args);
        public event CambiarJugadorEventHandler JugadorCambiado;

        public Entrenador(string nombre, int edad, string nacion, int sueldo, int puntosTactica)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.nacion = nacion;
            this.sueldo = sueldo;
            this.puntosTactica = puntosTactica;
        }


        //Esta es la acción de "Cambiar jugador" que mencionan en el enunciado, decidi hacerlo evento para poder enviar la información
        public void OnJugadorCambiado(string nombre1, int numero1, string nombre2, int numero2)
        {
            if(JugadorCambiado != null)
            {
                JugadorCambiado(this, new JugadorEventArgs() { Nombre = nombre1, NumeroC = numero1, NombreNew = nombre2, NumeroCNew = numero2 });
            }
        }

    }
}
