using System;

namespace MyNamespace
{
    class Program
    {
        static void provjera(int x, int y, int z, int w, string pass) {
            int brV = 0;
            int brM = 0;
            int brB = 0;
            int brS = 0;

            foreach (char item in pass)
            {
                if (!Char.IsLetterOrDigit(item))
                {
                    brS++;
                }
                else if (Char.IsDigit(item))
                {
                    brB++;
                }
                else 
                {
                    if (Char.IsLower(item))
                    {
                        brM++;
                    }
                    else
                    {
                        brV++;
                    }
                }
            }
            if ((brM >= x) && (brV >= y) && (brB >= w) && (brS >= z))
            {
                Console.WriteLine("Lozinka je uspjesno unesena");
            }
            else
            {
                Console.Write("Lozinka ne zadovoljava kriterije");
            }

        }
        static void Main(string[] args)
        {
            int x;
            int y;
            int z;
            int w;
            string pass;
            Console.WriteLine("Unesite broj malih slova: ");
            do
            {
                x = int.Parse(Console.ReadLine());
            } while (x <= 0);

            Console.WriteLine("Unesite broj velikih slova: ");
            do
            {
                y = int.Parse(Console.ReadLine());
            } while (y <= 0);

            Console.WriteLine("Unesite broj posebnih znakova: ");
            do
            {
                z = int.Parse(Console.ReadLine());
            } while (z <= 0);

            Console.WriteLine("Unesite broj znamenki: ");
            do
            {
                w = int.Parse(Console.ReadLine());
            } while (w <= 0);

            Console.WriteLine("Unesite lozinku koju želite provjeriti");
            pass = Console.ReadLine();

            provjera(x, y, z, w, pass);


            Console.ReadLine();
        }
    }
}