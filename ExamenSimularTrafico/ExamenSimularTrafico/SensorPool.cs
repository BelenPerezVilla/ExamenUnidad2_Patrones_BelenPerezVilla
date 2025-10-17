using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenSimularTrafico
{
   public class SensorPool
    {
        private List<Sensor> sensoresDisponibles = new List<Sensor>();
        private static int contadorId = 1;

        public SensorPool(int cantidadInicial)
        {
            for(int i = 0; i < cantidadInicial; i++)
            {
                sensoresDisponibles.Add(new Sensor(contadorId++));
            }
        }
        public Sensor ObtenerSensor()
        {
            foreach(var s in sensoresDisponibles)
            {
                if (!s.EnUso)
                {
                    s.EnUso = true;
                    return s;
                }
            }
            var nuevo = new Sensor(contadorId++);
            nuevo.EnUso = true;
            sensoresDisponibles.Add(nuevo);
            return nuevo;
        }
        public void LiberarSensor(Sensor s)
        {
            s.EnUso = false;
        }
    }
}
