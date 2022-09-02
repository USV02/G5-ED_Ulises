using System;

namespace Operaciones_básicas
{
    class Program
    {
        static void Main(string[] args)
        {
            //PRIMERA SERIE DE DATOS
            int sum = 2 + 9;
            int res = 9 - 2;
            int mul = 2 * 9;
            int div = 9 / 2;

            //SEGUNDA SERIE DE DATOS
            decimal dec = 8.0m / 5;

            //TERCERA SERIE DE DATOS
            int Pri = 18;
            int Sec = 4;
            decimal Res=Convert.ToDecimal(Pri)/Convert.ToDecimal(Sec);

            //QUINTA SERIE DE DATOS
            int val1 = 5;
            int val2 = 8;

            //SEPTIMA SERIE DE DATOS
            int val = 1;

            //ULTIMA SERIE DE DATOS
            int F = 108;

            //PRIMERA SERIE DE OPERACIONES
            Console.WriteLine("A continuacion re realizaran operaciones basicas");
            Console.WriteLine("Suma: "+sum);
            Console.WriteLine("Resta: "+res);
            Console.WriteLine("Multiplicacion: "+mul);
            Console.WriteLine("Division: "+div);
            Console.WriteLine("");
            Console.WriteLine("Presione la tecla Enter para la siguiente sucesion de operaciones");
            Console.ReadLine();

            //SEGUNDA SERIE DE OPERACIONES
            Console.WriteLine("Decimal: "+dec);
            Console.WriteLine("");
            Console.WriteLine("Presione la tecla Enter para la siguiente sucesion de operaciones");
            Console.ReadLine();

            //TERCERA SERIE DE OPERACIONES
            Console.WriteLine("Conversion de Int a Decimal: "+Res);
            Console.WriteLine("");
            Console.WriteLine("Presione la tecla Enter para la siguiente sucesion de operaciones");
            Console.ReadLine();

            //CUARTA SERIE DE OPERACIONES
            Console.WriteLine("Modulo de 400/4: "+(400%4));
            Console.WriteLine("Modulo de 27/4"+(27%4));
            Console.WriteLine("");
            Console.WriteLine("El primer modulo dio como resultado 0, indicando que el dividendo es divisible por el divisor");
            Console.WriteLine("");
            Console.WriteLine("Presione la tecla Enter para la siguiente sucesion de operaciones");
            Console.ReadLine();

            //QUINTA SERIE DE OPERACIONES
            Console.WriteLine("5 + 8 * 5: "+val1+val2*5);
            Console.WriteLine("(5 + 8) * 5: "+(val1+val2)*5);
            Console.WriteLine("");
            Console.WriteLine("Presione la tecla Enter para la siguiente sucesion de operaciones");
            Console.ReadLine();

            //SEXTA SERIE DE OPERACIONES
            Console.WriteLine("Serie de incremento");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Incremento "+i+": "+i);
            }
            Console.WriteLine("");
            Console.WriteLine("Serie de decremento");
            for (int i = 3; i < 0; i--)
            {
                Console.WriteLine("Decremento " + i + ": " + i);
            }
            Console.WriteLine("");
            Console.WriteLine("Presione la tecla Enter para la siguiente sucesion de operaciones");
            Console.ReadLine();


            //SEPTIMA SERIE DE OPERACIONES
            Console.WriteLine("Primero: "+val);
            Console.WriteLine("Segundo: "+val++);
            Console.WriteLine("Tercero: "+val);
            Console.WriteLine("Cuarto: "+(++val));
            Console.WriteLine("");
            Console.WriteLine("La segunda sucesion se escribio val++ y en el cuarto se escribio ++val");
            Console.WriteLine("");
            Console.WriteLine("Presiona la tecla Enter para lasiguiente sucesion de operaciones");
            Console.ReadLine();

            //ULTIMA SERIE DE OPERACIONES
            Console.WriteLine("Conversion de 108 grados Fahrenheit a Celsius");
            Console.WriteLine("Resultado final: "+(Convert.ToDouble(F)-32)/1.8);
            Console.WriteLine("");
            Console.WriteLine("Presiona la tecla Enter para finalizar el codigo");
            Console.ReadLine();


        }
    }
}
