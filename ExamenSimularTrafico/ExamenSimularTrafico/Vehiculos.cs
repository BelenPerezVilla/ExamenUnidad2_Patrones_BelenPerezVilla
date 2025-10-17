using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenSimularTrafico
{
   public class Vehiculos
    {
        public int Id { get; private set; }
        public string Tipo { get; private set; }
        public bool EnUso { get; set; }

        public Vehiculos(int id, string tipo)
        {
            Id = id;
            Tipo = tipo;
            EnUso = false;
        }
       
    }
}
