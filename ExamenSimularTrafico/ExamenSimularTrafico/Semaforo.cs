using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExamenSimularTrafico
{
    public enum EstadoSemaforo { verde, Amarillo, Rojo}
    public class Semaforo
    {
        public string Id { get; private set; }
        public EstadoSemaforo Estado { get; private set; }
        private int tiempoCambio = 0;

        public Semaforo(string id)
        {
            Id = id;
            Estado = EstadoSemaforo.Rojo;
        }
        public void CambiarEstado()
        {
            tiempoCambio++;
            if(tiempoCambio % 3 ==0 )
            {
                Estado = Estado == EstadoSemaforo.verde ? EstadoSemaforo.Rojo : EstadoSemaforo.verde;
            }
            
        }
        public void MostrarEstado()
        {
            Console.WriteLine($"Semaforo {Id}: {Estado}");
        }

    }
}
