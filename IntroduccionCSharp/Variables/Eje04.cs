namespace IntroduccionCSharp.Variables
{
    public class Eje04
    {
        public Eje04()
        {
            /**
            * Interpolación de Strings
            * 
            **/

            string nombre = "Juan";
            int edad = 18;
            decimal salario = 19000.50m;

            // Concatenación de strings
            Console.WriteLine("Hola " + nombre + ". tienes " + edad + " años");

            // Format string
            string mensaje = string.Format("{0} tiene {1} años y gana {2:C2}", nombre, edad, salario);
            Console.WriteLine(mensaje);

            // String literales
            Console.WriteLine($"Nombre: {nombre}, Edad: {edad}, Salario: {salario}");

        }
    }
}