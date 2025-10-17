using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenSimularTrafico
{
    public class Sensor
    {
        public int Id { get; private set; }
        public bool EnUso { get; set; }

        public Sensor(int id) 
        {
            Id = id;
            EnUso = false;
        }
        public int DetectarVehiculos()
        {
            Random rnd = new Random();
            return rnd.Next(0, 10);
        }
    }
}
