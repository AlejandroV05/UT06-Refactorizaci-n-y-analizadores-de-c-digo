namespace ExtraerInterfaz
{
    internal class Program
    {
        //Extraer Interfaz
        //Este patrón crea una interfaz para 
        //estandarizar la funcionalidad de varias clases 
        //con métodos similares

        //Código antiguo
        /**public double CalcularArea(double radio)
            {
                return Math.PI * radio * radio;
            }
        }

        public class Rectangulo
        {
            public double CalcularArea(double baseRect, double altura)
            {
                return baseRect * altura;
         }
         * 
         */

        //Código nuevo
        /*
         * public interface IFigura
        {
            double CalcularArea();
        }

        public class Circulo : IFigura
        {
            private double radio;

            public Circulo(double radio)
            {
                this.radio = radio;
            }

            public double CalcularArea()
            {
                return Math.PI * radio * radio;
            }
        }

        public class Rectangulo : IFigura
        {
            private double baseRect;
            private double altura;

            public Rectangulo(double baseRect, double altura)
            {
                this.baseRect = baseRect;
                this.altura = altura;
            }

            public double CalcularArea()
            {
                return baseRect * altura;
            }
        }

         */



    }
}
