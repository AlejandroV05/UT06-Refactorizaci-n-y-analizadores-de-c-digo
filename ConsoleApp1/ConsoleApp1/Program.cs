namespace ConsoleApp1
{
    internal class Program
    {


       
        static void Main(string[] args)
        {
            Point punto =new(1,2);
            Console.WriteLine(punto.Coordenadas());
            Console.Read();
        }

        /// <summary>
        /// Representa un punto en el espacio.
        /// </summary>
        public class Point
        {

            /// <value>Propiedad de X correspondiente a la coordenada X </value>
          public int X {  get; set; }
            /// <value>Propiedad de Y correspondiente a la coordenada Y </value>
            public int Y { get; set; }


            /// <summary>
            /// Constructor de la clase <c>Point</c> que inicializa un nuevo punto a (<param name="x"></param>,<param name="y"></param>)
            /// </summary>
            /// <param name="x">Correspondiente a la coordenada X del punto</param>
            /// <param name="y">Correspondiente a la coordenada Y del punto</param>
            public Point(int x, int y) {
                X = x;
                Y = y;
            }

            /// <summary>
            /// <example> Por ejemplo:
            /// <code>
            /// Point m = new Point(2.4);
            /// m.Coordenadas();
            /// </code>
            /// </example>
            /// </summary>
            /// <returns>Regresa una cadena con las coordenadas del punto</returns>
            public String Coordenadas() {
                return $"{X},{Y}";
            }

            /// <summary>
            /// Obtiene las coordenadas del punto
            /// </summary>
            /// <returns>Una cadena con las coordenadas del punto</returns>
            /// <see cref="Coordenadas"/>
            public string CoordenadasComplejas()
            {
                return $"({X},{Y})";
            }
        }
    }
}
