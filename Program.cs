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
            double a = 0, b = 1, E = 0.01;

            double k = (Math.Pow(5, 0.5) - 1)/ 2;

            double xl = b - k * (b - a);
            double xr = a + k * (b - a);

            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());
            Console.WriteLine(k.ToString());
            Console.WriteLine(xl.ToString()); 
            Console.WriteLine(xr.ToString());

            while ((b - a) > E)
            {
                if ( 2*Math.PI*xl*xl+2/xl < 2 * Math.PI * xr * xr + 2 / xr)
                {
                    b = xr;
                    xr = xl;
                    xl = b - k * (b - a);
                }
                else
                {
                    a = xl;
                    xl = xr;
                    xr = a + k * (b - a);
                }
            }

            double z = (a + b) / 2;

            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());
            Console.WriteLine(k.ToString());
            Console.WriteLine(xl.ToString());
            Console.WriteLine(xr.ToString());

            Console.WriteLine("To jest promień ");
            Console.WriteLine(z.ToString());

            Console.WriteLine("To jest pole ");
            Console.WriteLine(2 * Math.PI * z * z + 2 / z);
          

        }
    }
}

