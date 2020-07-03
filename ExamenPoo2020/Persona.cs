using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPoo2020
{
    public abstract class Persona
    {
        protected string nombre;
        protected int edad;
        protected string nacion;
        protected int sueldo;


        public string Nombre { get => nombre; }
        public int Edad { get => edad; }
        public string Nacion { get => nacion; }
        public int Sueldo { get => sueldo; }


    }
}
