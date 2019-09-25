using System;
using System.Collections.Generic;

namespace PracticaPolimorfismo
{

        class Campaña
        {
            public List<ICalculable> medios { get; set; }
            public string nombreCampaña { get; set; }
            public int presupuesto { get; set; }


            public Campaña(string campaña, int dineroDisponible)
            {
                nombreCampaña = campaña;
                medios = new List<ICalculable>();
                presupuesto = dineroDisponible;
            }

            public void agregarMedio(ICalculable medio)
            {
                medios.Add(medio);
            }

            public int costoCampnia ()
            {
                int costo = 0;
                foreach (ICalculable m in medios)
                {
                    costo = m.costoUnitario * m.tiempoUso;
                }

                return costo;
                
            }
           
        }
    
}
