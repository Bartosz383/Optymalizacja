using System;

/* 
Założenia:

r > 0 
H > 0

Rozwiązanie analityczne:

V = Pp * H  ->  H = V / (pi* r^2)

Pp = V / H

Pc = 2 * pi * r^2 + 2 * pi * r * H  ->  Pc = 2 * pi * r^2 + 2 * V / r

Pc' = 4 * pi * r - 2 * V / r^2 = 0

r^3 = V / ( 2 * pi )

r = 0,54

H = 1,09

*/




namespace Optymalizacja
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname, lname;
            Console.Write("Enter your first name: ");
            fname = Console.ReadLine();
            Console.Write("Enter your last name: ");
            lname = Console.ReadLine();
            Console.Write("You full name is " + fname + " " + lname);
        }
    }
}

