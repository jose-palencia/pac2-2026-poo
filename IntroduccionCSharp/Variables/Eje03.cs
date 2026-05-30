namespace IntroduccionCSharp.Variables
{
    public class Eje03
    {
        public Eje03()
        {
            /* Conversión de tipos */
            
            // Conversión implícita
            // int entero = 100;
            // long largo = entero;
            // double doble = largo;

            // Conversion explicita (cast, puede perder datos)
            // double pi = 3.14159;
            // int truncado = (int)pi; // 3

            // Métodos de conversión
            // string numeroStr = "42";
            // int numero = int.Parse(numeroStr);
            // int otroNumero = Convert.ToInt32(numeroStr);

            if(int.TryParse("2", out int resultado))
            {
                Console.WriteLine(resultado);
            }
            else
            {
                Console.WriteLine("La cadena de texto no es un número válido.");
            }
            //int numeroX = int.Parse("dos");

            // Console.WriteLine(numeroX);
        }
    }
}