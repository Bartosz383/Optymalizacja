using System;

/* 
Założenia:

r > 0 
H > 0
V > 0

Rozwiązanie analityczne:

V = Pp * H  ->  H = V / (pi* r^2)

Pp = V / H

Pc = 2 * pi * r^2 + 2 * pi * r * H  ->  Pc = 2 * pi * r^2 + 2 * V / r

Pc' = 4 * pi * r - 2 * V / r^2 = 0

r^3 = V / ( 2 * pi )

r = 0,54

H = 0,58

*/

namespace Optymalizacja
{
    class Program
    {
        static void Main(string[] args)
        {
            double V, r, Pc, H, P;

            V = 1;

            for (double i = 0; i < 10; i++)
            {
                P = i * i * Math.PI;
                Console.Write(P);
            }

            Console.Write("\n*******************");

           // Console.Write("Podaj wartosć objętości: ");

           // V = Convert.ToDouble(Console.ReadLine());

            r = Math.Pow(V / ( 2 * Math.PI ), 1.0/3);

            Pc = 2 * Math.PI * Math.Pow(r, 2) + 2 * V / r;

            H = V / (Math.PI * r);

            Console.Write("\nMinimalne pole powierzchni to: " + Pc + " Minimalny promień to: " + r + " Minimalna wysokosć to: " + H);
        }
    }
}

