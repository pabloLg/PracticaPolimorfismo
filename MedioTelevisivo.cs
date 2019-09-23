using System;

namespace PracticaPolimorfismo
{
    partial class Program
    {
        abstract class MedioTelevisivo  : Medio
        {   
            
            public virtual int CostoSpot { get; set; }           
            public DateTime tiempoAire { get; set; }
            
        }  
    }
}
