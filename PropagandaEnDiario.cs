using System;

namespace PracticaPolimorfismo
{
    partial class Program
    {
        class PropagandaEnDiario : MedioGrafico
        {
          
            public int costoDiseñador ;
            public int costoDiario;           
            public DateTime fechaCreacion { get; set; }         

            public PropagandaEnDiario(string nombreS,  int diseñador,int diario, int duracion)
            {
                nombre = nombreS;
                costoDiseñador = diseñador;
                costoDiario = diario;
                tiempoUso = duracion;
                fechaCreacion = DateTime.Today;
                costoUnitario = calcularCosto();
            }


            private int calcularCosto()
            {
                int costo = costoDiseñador + costoDiario * tiempoUso;
                return costo;
            }



        }
    }
}
