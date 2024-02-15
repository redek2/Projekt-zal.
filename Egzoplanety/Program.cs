
using System.Reflection.Metadata.Ecma335;

public class Egzoplanety
{
    public static double MasaZiemia(double masaj)
    {
        return masaj * 317.83;
    }

    public static double MasaJowisz(double masaz)
    {
        return masaz * 0.00315;
    }

    public static double PromienZiemia(double pj)
    {
        return pj * 11.2;
    }

    public static double PromienJowisz(double  pz)
    {
        return pz * 0.089;
    }
    public static void Main(string[] args)
    {
        int a, b, c;
        double masaj, masaz, mz, mj, pz, pj, prj, prz;
        Console.WriteLine("Co chcesz zrobić?\n\n1. Zamiana jednostek masy\n2. Zamiana jednostek promienia\n");
        a = int.Parse(Console.ReadLine());

            if (a == 1)
            {
            Console.WriteLine("\n1. Masa Jowisza -> Masa Ziemi\n2. Masa Ziemi -> Masa Jowisza\n");
            b = int.Parse(Console.ReadLine());
            if (b == 1)
            {
                Console.WriteLine("\nPodaj masę planety w odniesieniu do masy Jowisza");
                masaj = double.Parse(Console.ReadLine());
                mz = MasaZiemia(masaj);
                Console.WriteLine($"Masa planety wynosi {masaj} mas Jowisza, więc wynosi {mz} mas Ziemi");

            }
            else if (b == 2)
            {
                Console.WriteLine("\nPodaj masę planety w odniesieniu do masy Ziemi");
                masaz = double.Parse(Console.ReadLine());
                mj = MasaJowisz(masaz);
                Console.WriteLine($"Masa planety wynosi {masaz} mas Ziemi, więc wynosi {mj} mas Jowisza");
            }
            else
            {
                Console.WriteLine("Podaj prawidłową wartość");
            }

            }


        else if (a == 2)
        {
            Console.WriteLine("\n1. Promień Jowisza -> Promień Ziemi\n2. Promień Ziemi -> Promień Jowisza\n");
            c = int.Parse(Console.ReadLine());
                if (c == 1)
                {
                    Console.WriteLine("\nPodaj promień planety w odniesieniu do promienia Jowisza");
                    pj = double.Parse(Console.ReadLine());
                    prj = PromienZiemia(pj);
                    Console.WriteLine($"Promień planety wynosi {pj} promienia Jowisza, więc wynosi {prj} promienia Ziemi");

                }
                else if (c == 2)
                {
                    Console.WriteLine("\nPodaj promień planety w odniesieniu do promienia Ziemi");
                    pz = double.Parse(Console.ReadLine());
                    prz = PromienJowisz(pz);
                    Console.WriteLine($"Promień planety wynosi {pz} promienia Ziemi, więc wynosi {prz} promienia Jowisza");
                }
                else
                {
                    Console.WriteLine("Podaj prawidłową wartość");
                }

            }
        else
        {
            a = 0;
            Console.WriteLine("Podaj prawidłową wartość");
            a = int.Parse(Console.ReadLine());
        }
        }
    }