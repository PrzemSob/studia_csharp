using System;

class Program
{
    public static void Main(string[] args)
    {
        // Uzytkownik wprowadza A,B i C
        Console.WriteLine("Podaj A:");
        double psA = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj B:");
        double psB = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj C:");
        double psC = double.Parse(Console.ReadLine());


        //deklaracja zmiennych dla delty i x-ow
        double psdelta = 0;
        double psx1 = 0;
        double psx2 = 0;
        double psx0 = 0;
        double psx = 0;
        double pspier_z_del = 0;



        //jezelia a i c nie rowna sie 0 program oblicza delte
        if (psA != 0 && psC != 0)
        {
            psdelta = (psB * psB) - 4 * psA * psC;

            //print delty
            Console.WriteLine($"Δ = {psdelta}");

            //obliczenie x1 i x2 dla delty wiekszej od zera
            if (psdelta > 0)
            {
                pspier_z_del = Math.Sqrt(psdelta);

                psx1 = (-psB - pspier_z_del) / (2 * psA);
                psx2 = (-psB + pspier_z_del) / (2 * psA);

                //print wyniku x1 i x2
                Console.WriteLine($"x1 = {psx1}");
                Console.WriteLine($"x2 = {psx2}");
            }

            //obliczenie x dla delty rownej 0
            else if (psdelta == 0)
            {
                psx0 = (-(psB)) / 2 * psA;

                //print wyniku x
                Console.WriteLine($"x = {psx0}");
            }

            //print informacji o braku rozwiązań dla delty mniejszej od zera
            else
            {
                Console.WriteLine("Delta jest mniejsza od zera, brak rozwiązań równania");
            }
        }

        //dla a roznego od zera i c = 0 rownanie jest liniowe ax-b=0
        else
        {
            psx = -psB / psA;
            Console.WriteLine($"x = {psx}");
        }
    }
}
