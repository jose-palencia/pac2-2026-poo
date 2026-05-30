namespace IntroduccionCSharp.Variables;

/**
VARIABLE: es un espacio en la memoria RAM con un nombre que almacena un valor

para definir una variable en c#

tipoDeDato nombreVariable = Valor Opcional
string nombre = "Juan Perez";
int edad = 20;

Tipo    Descripción     Tamaño
int     Entero          32 bits
long    Entero grande   64 bits
float   Decimal simple  32 bits
double  Decimal doble   64 bits
decimal Decimal exacto  128 bits
bool    Boleado         8 bits => 1 byte
char    Carácter        16 bits
string  Texto           Variable

*/

public class Eje01
{
    public Eje01() // método constructor
    {
        float f = 0.1f;
        double d = 0.1;
        decimal m = 0.1m;

        Console.WriteLine(f + f + f + f + f); // 0.5000001 inexacto
        Console.WriteLine(d + d + d + d + d); // 0.50000000000001 inexacto
        Console.WriteLine(m + m + m + m + m); // 0.5 exacto
    }
}
