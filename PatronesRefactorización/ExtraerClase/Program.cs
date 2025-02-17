namespace ExtraerClase
{
    internal class Program
    {
        //Mover Método
        //Este patrón traslada un método de una clase a
        //otra cuando su funcionalidad pertenece más a otra clase.

        /*Código antiguo
         *La clase Info alberga mucha información(si el ejemplo fuera más específico sería más obvio)
         *public class Info
         *{
         *  public int a { get; set; }
         *  public int b { get; set; }
         *  public int c { get; set; }
         *  public int d { get; set; }
         *  public int e { get; set; }
         *}
         */

        //Aplicando método
        //Ahora la información de una clase es manejada por dos clase
        //Dando al programador la oportunidad de trabajar mejor en ellas
        public class Info
        {
            public int a { get; set; }
            public int b { get; set; }
            public int c { get; set; }
        }
        public class Info2
        {
            public int d { get; set; }
            public int e { get; set; }
            public Info Info { get; set; }
        }

    }
}
