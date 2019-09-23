using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PracticaPolimorfismo
{
  
    class Reporte<T> where T: ICalculable

    {
        /// detallar los gastos de la campaña
        /// 
        public void HacerReporte(List<ICalculable> costos)
        {
            try
            {
                foreach (ICalculable c in costos)
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
