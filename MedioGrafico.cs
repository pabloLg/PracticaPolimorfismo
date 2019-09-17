using System;

namespace PracticaPolimorfismo
{
    partial class Program
    {
        abstract class MedioGrafico : ICalculable
        {
            public int costoUnitario { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public DateTime tiempoUso { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        }
    }
}
