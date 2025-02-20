namespace ReemplazarNúmeroMágico_ConConstanteSimbólica
{
    internal class Program
    {
        //Reemplazar Número Mágico con Constante Simbólica
        //Se reemplazan constantes con nombres descriptivos
        //haciendo el código más legible y fácil de mantener


        //Código viejo
        //La constante no está definida
        /*public class Constante
         * {
         *  public int CalcularConstantes(int a)
         *  {
         *      return 'constante'+a;
         *  }
         * }
         */

        //Código nuevo
        //Se da a la constante mejor definición
        public class Constante
        {
            private const double R = 8.314;

            public double Calcular()
            {
                return 1 * 10 / (2 * R * 700);
            }
        }

    }
}
