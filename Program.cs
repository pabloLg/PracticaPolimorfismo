using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPolimorfismo
{
    partial class Program
    {

        static void Main(string[] args)
        {

            PropagandaEnDiario propagandaDiario = new PropagandaEnDiario("aviso publicitario", 50, 1000, 5);
            var  report = new Reporte<ICalculable>();
            Campaña campaña = new Campaña("Publicidad" , 20000);
            campaña.agregarMedio(propagandaDiario);

            report.HacerReporte(campaña.medios);
            Console.ReadKey();
        }
    }
}
