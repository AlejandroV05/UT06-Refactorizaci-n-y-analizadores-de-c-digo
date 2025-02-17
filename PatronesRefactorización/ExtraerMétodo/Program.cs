namespace ExtraerMétodo
{
    internal class Program
    {
        //Extraer método
        //Es un método que extraen otros métodos dentro de otro que realiza una tarea específica
        // haaciendo el método menos complejo y más legible

        //Creamos una función donde se sume a + b y c sea la resta de a
        //con una condición

        /**Código antiguo
         * 
         * Podemos ver este método se ha complicado de manera injustificada
        public int funcion(int a, int b)
        {
            a += b;
            if (a > 10)
            {
                int c= a - a;
            }
        return c;
        }
        */

        //Aplicando método
        //Ahora 'c' es más fácil de utilizar
        private int c(int a)
        {
            return a - a;
        }
        public int funcion(int a, int b)
        {
            a += b;
           return c(a);
        }
    }
}
