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
            double ZP, a, b, d, r1, r2, P1, P2, V;

            V = 1;

            a = 0;
            b = 2;

            ZP = (Math.Pow(5, 1/2) - 1 ) /2;
            d = ZP * (b - a);
            r1 = a + d;
            r2 = b - d;
            P1 = 2 * Math.PI * Math.Pow(r1, 2) + 2 * V / r1;
            P2 = 2 * Math.PI * Math.Pow(r2, 2) + 2 * V / r2;

            if (P1 < P2)
            {
                r2 = a;
                r1 = r2;
                P1 = 2 * Math.PI * Math.Pow(r1, 2) + 2 * V / r1;
                P2 = 2 * Math.PI * Math.Pow(r2, 2) + 2 * V / r2;
            }
            else if (P1 > P2)
            {
                r1 = b;
                r2 = r1;
                P1 = 2 * Math.PI * Math.Pow(r1, 2) + 2 * V / r1;
                P2 = 2 * Math.PI * Math.Pow(r2, 2) + 2 * V / r2;
            }

            Console.WriteLine(P1.ToString());
            Console.WriteLine(P2);

            Console.ReadLine();
           
	        
            // float V, r, Pc, H;
            
            // V = 1;

            // int x = 0;
            // double y =0;
            // Console.WriteLine("Podaj liczbe");
            // x = Convert.ToInt32(Console.ReadLine());
            // V = float.Parse("50.32", System.Globalization.CultureInfo.InvariantCulture);
            // Console.WriteLine("podales {0}  \n", x);
            // Console.ReadLine();
            // Console.WriteLine(V);
        
            // Console.Write("Cześć. \nJestem programem do szukania minimalnego pola powierzchni dla walca o objętosći V = 1. W jakim przedziale szukasz minimum drogi użytkowniku? ");       

            // Console.Write("\n*******************");

           // Console.Write("Podaj wartosć objętości: ");

           // V = Convert.ToDouble(Console.ReadLine());

            // r = Math.Pow(V / ( 2 * Math.PI ), 1.0/3);

            // Pc = 2 * Math.PI * Math.Pow(r, 2) + 2 * V / r;

            // H = V / (Math.PI * r);

            //Console.Write("\nMinimalne pole powierzchni to: " + Pc + " Minimalny promień to: " + r + " Minimalna wysokosć to: " + H);
        }
    }
}

