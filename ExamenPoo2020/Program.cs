using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPoo2020
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Equipo> equipos = new List<Equipo>(2);
            List<string> nombres = new List<string>() { "Pedro", "Juan", "Alberto", "diego", "Matias", "Andres", "Roberto", "George", "Francisco", "Paolo", "Joaquin", "Cristian", "Carlos", "julio", "Alvaro", "Vicente","nicolas", "Sebastian", "Luca", "Jeremy", "Ignacio", "Cristobal"};
            bool loop = true;
            while (loop)
            {
                
                Console.WriteLine("Bienvenidos al simulador de futbol.");
                Console.WriteLine("1) Crear Equipo\n2)salir.\n3)Jugar");

                string opc;
                do
                {
                    opc = Console.ReadLine();
                    if (opc != "1" && opc != "2" && opc != "3")
                        Console.Write("Escriba una opción del menú: ");
                } while (opc != "1" && opc != "2" && opc != "3");

                switch (opc)
                {
                    case "1":
                        Console.Write("Porfavor ingrese el nombre de su equipo: ");   string nombreE = Console.ReadLine();

                        Console.Write("Su equipo es nacional o de liga? (Nac/Liga)");
                        string isNac;
                        do {
                            isNac = Console.ReadLine();
                            if (isNac != "Nac" && isNac != "Liga")
                                Console.Write("Comando incorrecto, confirme escribiendo (Nac/Liga): ");
                        } while (isNac != "Nac" && isNac != "Liga");

                        bool esNacional;
                        string nacionE = null;
                        if(isNac == "Nac")
                        {
                            Console.Write("Escriba la nacionalidad de su equipo: "); nacionE = Console.ReadLine();
                            esNacional = true;
                        }
                        else
                        {
                            Console.Write("Escriba el nombre de la liga: "); nacionE = Console.ReadLine(); 
                            esNacional = false;
                        }
                        Equipo equipo = new Equipo(nombreE, esNacional, nacionE);

                        Entrenador entrenador = new Entrenador("Sergio", 34, "Chileno", 2300000, 50);
                        Medico medic = new Medico("Agustin", 26, "Chileno", 3000000, 3000);

                        equipo.Trainer = entrenador;
                        equipo.Medico = medic;

                        Random rnd = new Random();
                        for (int i = 0; i < 15; i++)
                        {
                            int random = rnd.Next(0, 15);
                            Jugador player = new Jugador(nombres[random], i, "Chileno", i, i, i, i);
                            equipo.AgregarJugador(player);
                        }

                        equipos.Add(equipo);

                        break;

                    case "2":
                        loop = false;
                        break;

                    case "3":
                        Partido partido = new Partido(equipos[0], equipos[1]);
                        Console.WriteLine("\n---------------------------------------------------------------------------\n");
                        Console.WriteLine(partido.Equipo1.InformacionEquipo());
                        Console.WriteLine("\n---------------------------------------------------------------------------\n");
                        Console.WriteLine(partido.Equipo2.InformacionEquipo());
                        Console.WriteLine("\n---------------------------------------------------------------------------\n");
                        Console.WriteLine(partido.MostrarInfoPartido());
                        Console.WriteLine("\n---------------------------------------------------------------------------\n");
                        break;

                }
                
            }

        }
    }
}
