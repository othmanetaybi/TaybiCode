using System;

namespace Exercice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbr, cmpt = 0;


            do
            {
                Console.Write("Donner un nbr Entier ");
                nbr = int.Parse(Console.ReadLine());
            }
            while (nbr < 0);


            for (int i = 0; i < nbr / 2; i++)
            {
                if (nbr % 2 == 0)
                    cmpt++;
            }
            if (cmpt > 2)
                Console.WriteLine("pas premier");
            else
                Console.WriteLine("premier");
            Console.ReadKey();
        }
    }
}
