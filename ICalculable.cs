using System;

namespace PracticaPolimorfismo
{
    partial class Program
    {
        interface ICalculable
        {
            int costoUnitario { get; set; }
            DateTime tiempoUso { get; set; }
            
        }                    
    }
}
