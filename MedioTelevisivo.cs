using System;

namespace PracticaPolimorfismo
{
    partial class Program
    {
        abstract class MedioTelevisivo  
        {   
            
            public virtual int CostoSpot { get; set; }           
            public DateTime tiempoAire { get; set; }
            
        }  
    }
}
