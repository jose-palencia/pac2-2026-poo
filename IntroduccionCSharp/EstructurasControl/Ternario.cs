namespace IntroduccionCSharp.EstructurasControl
{
    public class Ternario
    {
        public Ternario()
        {
            // EL ternario se utiliza en condiciones cortas 
            int edad = 20;

            string mensaje = (edad >= 18) ? "Mayor de edad" : "Menor de edad";
            Console.WriteLine(mensaje);
        }
    }
}