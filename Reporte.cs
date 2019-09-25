using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PracticaPolimorfismo
{
  
    class Reporte<T,Q> where T: ICalculable 

    {
        /// detallar los gastos de la campaña
        /// 
        public void HacerReporte(List<T> costos, Q algo)
        {
            try
            {
                
                foreach (T c in costos)
                {
                    Console.WriteLine("Nombre: " + c.nombre );
                    Console.WriteLine("Tiempo de duracion: " + c.tiempoUso + " horas ");
                    Console.WriteLine("Costo: $" + c.costoUnitario);
                }
            }
            catch(Exception e)
            {
                throw new Exception("Error esta aca");
            }
           
            
        }
    }
}
