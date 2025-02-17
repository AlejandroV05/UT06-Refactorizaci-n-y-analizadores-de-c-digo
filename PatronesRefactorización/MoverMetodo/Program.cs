namespace MoverMetodo
{
    internal class Program
    {
        //Mover método
        //Este método consiste en mover un método 
        //de una clase a otra cuando su funcionalidad lo
        //requiera. Esto mejora el diseño

        /*Código antiguo
         * 
         * Como se puede ver la clase Info2 requiere más información de Info1
         * como para estar en clases diferentes
         * public class Info2
         * {
         *      public int c(int a)
         *      {
         *          return a-a;
         *      }
         * }
         * 
         * public class info1
         * {
         *      public int funcion(int a, int b)
         *      {
         *          int a+=b;
         *          returnInfo2.c(a);
         *      }
         * }
         */

        //Nuevo código
        //Ahora c se encuentra en la misma clase que 'funcion'
        public class Info
        {
            private int c(int a)
            {
                return a-a;
            }
            public int funcion(int a, int b)
            {
                a+= b;
                return c(a);
            } 
        }
    }
}
