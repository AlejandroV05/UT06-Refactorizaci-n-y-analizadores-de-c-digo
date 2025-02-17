namespace ReemplazarCondicionalConPolimorfismo
{
    internal class Program
    {
        //https://refactoring.guru/replace-conditional-with-polymorphism
        //Reemplazar Condicional con Polimorfismo
        //Se usa el polimorfismo como herencia en vez de condicionales switch o if
        //eliminando condicionales y asegurando un código más extensible

        //Viejo código
        /*class Info{
         *  int funcion(){
         *      switch(var){
         *          case 1:
         *              return a;
         *          case 2:
         *              return b;
         *          case 3:
         *              return c;
         *      }
         *  }
         * }
         */

        //Nuevo código
        /** abstract class Info
         {
             abstract int function();
         }
         
         class clase1 extends function{
            int function(){
                 return a;
             }
         }
         class clase2 extends function{
            int function(){
                 return b;
             }
         }
         class clase3 extends function{
           int function(){
                return c;
            }
        }
         */
    }
}
