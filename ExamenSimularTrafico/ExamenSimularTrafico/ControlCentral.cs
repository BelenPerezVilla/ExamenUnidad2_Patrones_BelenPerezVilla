using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenSimularTrafico
{
    public class ControlCentral
    {
        private static ControlCentral instance;
        private List<Semaforo> semaforos = new List<Semaforo>();
        private VehiculoPool vehiculoPool;
        private SensorPool sensorPool;
        private Random rnd = new Random();

        private ControlCentral() { }
        public static ControlCentral Instance
        {
            get
            {
                if (instance == null)
                    instance = new ControlCentral();
                return instance;
            }
        }
        public void Inicializar(VehiculoPool vpool, SensorPool spool, List<Semaforo> listaSemaforos)
        {
            vehiculoPool = vpool;
            sensorPool = spool; 
            semaforos = listaSemaforos;
        }
        public void SimularPaso()
        {
            Console.WriteLine("\n===== CICLO DE SIMULACION ======");

            foreach(var semaforo in semaforos)
            {
                semaforo.CambiarEstado();
                semaforo.MostrarEstado();

                var sensor = sensorPool.ObtenerSensor();
                int vehiculosEsperando = sensor.DetectarVehiculos();
                Console.WriteLine($"Sensor {sensor.Id}: {vehiculosEsperando} vehiculos detectados.");
                if(semaforo.Estado == EstadoSemaforo.verde && vehiculosEsperando > 0)
                {
                    List<int> idsVehiculos = new List<int>();
                    for(int i = 0; i< vehiculosEsperando; i++)
                    {
                        var vehiculo = vehiculoPool.ObtenerVehiculo();
                        
                        vehiculoPool.LiberarVehiculo(vehiculo);
                        idsVehiculos.Add(vehiculo.Id);
                    }
                    Console.WriteLine(" Vehículos que pasaron: [" + string.Join(", ", idsVehiculos) + "]");
                }
                sensorPool.LiberarSensor(sensor);
            }
            Console.WriteLine("===============================");
        }
    }
}
