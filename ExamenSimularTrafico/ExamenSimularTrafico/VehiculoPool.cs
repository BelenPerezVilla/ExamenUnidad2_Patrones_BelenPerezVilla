using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenSimularTrafico
{
    public class VehiculoPool
    {
        private List<Vehiculos> vehiculosDisponibles = new List<Vehiculos>();
        private static int contadorId = 1;

        public VehiculoPool(int cantidadInicial)
        {
            for (int i = 0; i < cantidadInicial; i++)
            {
                vehiculosDisponibles.Add(new Vehiculos(contadorId++, "Auto"));
            }
        }
        public Vehiculos ObtenerVehiculo()
        {
            foreach(var v in vehiculosDisponibles)
            {
                if (!v.EnUso)
                {
                    v.EnUso = true;
                    return v;
                }
            }
            // Si no hay disponibles, crear uno nuevo (expansion del pool)
            var nuevo = new Vehiculos(contadorId++, "Auto Extra");
            nuevo.EnUso = true;
            vehiculosDisponibles.Add (nuevo);
            return nuevo;
        }
        public void LiberarVehiculo(Vehiculos v)
        {
            v.EnUso = false;
        }
    }
}
