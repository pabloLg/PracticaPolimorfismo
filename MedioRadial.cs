﻿using System;

namespace PracticaPolimorfismo
{
    partial class Program
    {
        abstract class MedioRadial : ICalculable
        {
            public int costoUnitario { get; set ; }
            public int tiempoUso { get ; set ; }
            public string nombre { get ; set ; }
        }
    }
}
