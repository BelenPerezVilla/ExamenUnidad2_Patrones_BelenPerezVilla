using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExamenSimularTrafico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Simulador de Trafico de Ciudad ===\n");

            //Crear pools
            var vehiculoPool = new VehiculoPool(20);
            var sensorPool = new SensorPool(5);

            //Crear Semaforos
            var semaforos = new List<Semaforo>
            {
               new Semaforo("A1"),
               new Semaforo("B2"),
               new Semaforo("C3"),
               new Semaforo("D4")
            };
            //Inicializar el controlador central (singleton)
            // Crear instancia única del controlador
            var controlador1 = ControlCentral.Instance;
            controlador1.Inicializar(vehiculoPool, sensorPool, semaforos);

            // Intentar crear otra instancia (no debería crear una nueva)
            var controlador2 = ControlCentral.Instance;

            Console.WriteLine("\n--- COMPROBACIÓN DE INSTANCIAS SINGLETON ---");
            Console.WriteLine($"Controlador 1: {controlador1.GetHashCode()}");
            Console.WriteLine($"Controlador 2: {controlador2.GetHashCode()}");
            Console.WriteLine(controlador1 == controlador2
                ? " Ambos apuntan a la MISMA instancia (Singleton confirmado)."
                : " Se crearon instancias diferentes (Error en Singleton).");
            Console.WriteLine("\nPresiona ENTER para inciar la simulacion....");
            Console.ReadLine();

            //Simular varios ciclos
            for (int i = 0; i < 10;  i++)
            {
                Console.Clear(); // Limpia la consola antes de cada ciclo
                Console.WriteLine($"=== SIMULADOR DE TRÁFICO DE CIUDAD ===");
                Console.WriteLine($"Ciclo #{i + 1}\n");

                controlador1.SimularPaso();

                Console.WriteLine("\nPresiona ENTER para continuar al siguiente ciclo...");
                Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("\nSimulacion finalizada");

        }
    }
}
