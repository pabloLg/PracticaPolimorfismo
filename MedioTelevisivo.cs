using System;

namespace PracticaPolimorfismo
{
    partial class Program
    {
        abstract class MedioTelevisivo  
        {                                 

            public virtual int Costo { get; set; }
            public int costoUnitario { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public DateTime tiempoUso { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        }
    }
}
