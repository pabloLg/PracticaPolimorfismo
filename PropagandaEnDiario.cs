using System;

namespace PracticaPolimorfismo
{
    partial class Program
    {
        class PropagandaEnDiario : MedioGrafico
        {

              int _costoDiseñador { get; set; }
             int _costoDiario { get; set; }
             DateTime _fechaCreacion { get; set; } 

            public PropagandaEnDiario(string nombreS,  int diseñador,int diario, int duracion)
            {
                nombre = nombreS;
                _costoDiseñador = diseñador;
                _costoDiario = diario;
                tiempoUso = duracion;
                _fechaCreacion = DateTime.Today;
                costoUnitario = calcularCosto();
            }


            private int calcularCosto()
            {
                int costo = _costoDiseñador + _costoDiario * tiempoUso ;
 ;
                return costo;
            }



        }
    }
}

