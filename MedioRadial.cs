using System;

namespace PracticaPolimorfismo
{
    partial class Program
    {
        abstract class MedioRadial : ICalculable
        {

            public virtual int MiValor { get; set; }
            public int costoUnitario { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public DateTime tiempoUso { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        }
    }
}
