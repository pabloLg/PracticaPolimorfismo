using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPolimorfismo
{
    class Medio : ICalculable
    {
        public  int costoUnitario { get ; set ; }
        public  int tiempoUso { get ; set ; }
        public  string nombre { get ; set ; }

                          
    }
}
