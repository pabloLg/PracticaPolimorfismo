using System;

namespace PracticaPolimorfismo
{
    partial class Program
    {
        interface IPropuesta
        {
            int cotizacion { get; set; }
            DateTime fechaPropuesta { get; set; }
            
        }
    }
}
