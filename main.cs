using System;

class Program
{
    public static void Main(string[] args)
    {
        // Uzytkownik wprowadza A,B i C
        Console.WriteLine("Podaj A:");
        int psA = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Podaj B:");
        int psB = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Podaj C:");
        int psC = Convert.ToInt32(Console.ReadLine());


        //deklaracja zmiennych dla delty i x-ow
        int psdelta = 0;
        int psx1 = 0;
        int psx2 = 0;
        int psx0 = 0;
        int psx = 0;


        //jezelia a i c nie rowna sie 0 program oblicza delte
        if (psA != 0 && psC != 0)
        {
            psdelta = psB * psB - 4 * (psA * psC);
            //test 
            Console.WriteLine(psdelta);

            //obliczenie x1 i x2 dla delty wiekszej od zera
            if (psdelta > 0)
            {
                psx1 = Convert.ToInt32(-(psB) - Math.Sqrt(psdelta)) / 2 * psA;
                psx2 = Convert.ToInt32(-(psB) + Math.Sqrt(psdelta)) / 2 * psA;
                //test
                Console.WriteLine(psx1);
                Console.WriteLine(psx2);
            }

            //obliczenie x dla delty rownej 0
            else if (psdelta == 0)
            {
                psx0 = (-(psB)) / 2 * psA;

                //teset
                Console.WriteLine(psx0);
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
            psx =
            }
    }
}
