namespace ExtraerInterfaz
{
    internal class Program
    {
        //Extraer Interfaz
        //Este patrón crea una interfaz para 
        //estandarizar la funcionalidad de varias clases 
        //con métodos similares

        //Código nuevo
        class Función() : IFunción
        {
            public void A()
            {

            }
            public void B(int value)
            {

            }
            public int C()
            {
                return 0;
            }
        }
        interface IFunción
        {
            void A();   
            void B(int value);
            int C();
        }

    }
}
