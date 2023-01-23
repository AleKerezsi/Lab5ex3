using System;

namespace Lab5ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Scrieti un program care va numara toate aparitiile unui caracter intr-un sir de caractere. Atat caracterul cautat cat si sirul de caractere vor fi citite de la tastatura */

            Console.WriteLine("Introduceti sirul de caractere=  ");
            string sir = Console.ReadLine();

            if (string.IsNullOrEmpty(sir) || string.IsNullOrWhiteSpace(sir))
            {
                Console.WriteLine("Nu ai introdus nimic, sau ai introdus spatiu gol. Ruleaza din nou programul.");
                return;
            }

            Console.WriteLine("Introduceti un caracter= ");
            string crt = Console.ReadLine();

            // am considerat ca poate se vrea intentionat numara spatiu gol asa ca nu am mai verificat pentru ast
            if (string.IsNullOrEmpty(crt))
            {
                Console.WriteLine("Nu ai introdus nimic, sau ai introdus spatiu gol. Ruleaza din nou programul.");
                return;
            }

            int numarAparitii = NumaraAparitii(crt, sir);

            if (numarAparitii <= 0) Console.WriteLine(crt + " nu apare deloc in " + sir);
            else Console.WriteLine(crt + " apare de " + numarAparitii + " ori  in " + sir);

        }

        public static int NumaraAparitii(string crt, string sir)
        {
            int numarAparitii = 0;

            int lungimeSir = sir.Length;

            for (int i = 0; i < lungimeSir; i++) 
            {
                if (sir[i].ToString() == crt.ToString()) 
                    numarAparitii = numarAparitii + 1;
            }

            return numarAparitii;
        }
    }
}
