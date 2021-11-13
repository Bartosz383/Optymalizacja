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
            double ZP, a, b, d, r1, r2, P1, P2, V, E;

            E = 0.001;

            V = 1;

            a = 0;
            b = 1;

            ZP = (Math.Pow(5, 1/2) - 1 ) /2;
            d = ZP * (b - a);
            r1 = a + d;
            r2 = b - d;
            P1 = 2 * Math.PI * Math.Pow(r1, 2) + 2 * V / r1;
            P2 = 2 * Math.PI * Math.Pow(r2, 2) + 2 * V / r2;

            while ( (b - a) < E)
            {
                if (P1 < P2)
                {
                    a = r2;
                    r1 = r2;
                    r2 = b - d;
                    // P1 = 2 * Math.PI * Math.Pow(r1, 2) + 2 * V / r1;
                    // P2 = 2 * Math.PI * Math.Pow(r2, 2) + 2 * V / r2;
                }
                else
                {
                    b = r1;
                    r2 = r1;
                    r1 = a + d;
                    // P1 = 2 * Math.PI * Math.Pow(r1, 2) + 2 * V / r1;
                    // P2 = 2 * Math.PI * Math.Pow(r2, 2) + 2 * V / r2;
                }
            }

            Console.WriteLine( (a + b) / 2);

        }
    }
}

