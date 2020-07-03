using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPoo2020
{
    public class JugadorEventArgs : EventArgs
    {
        public string Nombre { get; set; }
        public int NumeroC { get; set; }

        public string NombreNew { get; set; }
        public int NumeroCNew { get; set; }
    }
}
