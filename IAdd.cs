using System;

namespace PracticaPolimorfismo
{
    partial class Program
    {
        interface IAdd
        {
            int costo { get; set; }
            DateTime tiempoEmpeza { get; set; }
            DateTime tiempoFin { get; set; }
        }
    }
}
