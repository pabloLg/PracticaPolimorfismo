using System.Collections.Generic;

namespace PracticaPolimorfismo
{
    partial class Program
    {
        public class PropagandaRadial : MedioRadial
        {
            public int costo { get; set; }
            public int segundos {get; set; }
            public int costoColaboradores(List<ComponentesDeMedios>  colaboradores)
            {
                return 0;
            }
            public int costoSegudos(int costoCanal)
            {

                return costoCanal * 2;
            }
        }
    }
}
