namespace PracticaPolimorfismo
{
    partial class Program
    {
        class PropagandaTelevisiva : MedioTelevisivo
        {
                         
            public int segundos { get; set; }
            public int costoSegudos(int costoCanal)
            {
                return costoCanal * 2;
            }
        }
    }
}
