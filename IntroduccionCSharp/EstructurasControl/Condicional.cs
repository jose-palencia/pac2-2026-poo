namespace IntroduccionCSharp.EstructurasControl
{
    public class Condicional
    {
        public Condicional()
        {
            int edad = 13;

            // if(edad >= 18)
            // {
            //     Console.WriteLine("Eres mayor de edad.");
            // }
            // else
            // {
            //     Console.WriteLine("Eres menor de edad.");
            // }

            // Console.WriteLine("-----------------------");

            if(edad < 13)
            {
                Console.WriteLine("Eres un niño");
            }
            else if (edad < 18)
            {
                Console.WriteLine("Eres un adolescente");
            }
            else if (edad < 65)
            {
                Console.WriteLine("Eres un adulto");
            }
            else
            {
                Console.WriteLine("Eres un adulto mayor");
            }

        }
    }
}