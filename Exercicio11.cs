using System;

namespace luby_incubadora11
{
    class Exercicio11
    {
        public int CalcularFatorial(int n)
        {
            int[] fatoriais = new int[n];
            int fatorial = n;
            for (int i = 0; i <= n - 1; i++)
            {
                fatoriais[i] = n - i;
            }
            for (int i = 1; i < n - 1; i++)
            {
                fatorial *= fatoriais[i];
            }
            return fatorial;
        }
        static void Main()
        {
            Exercicio11 p = new Exercicio11();
            Console.WriteLine(p.CalcularFatorial(5));
        }
    }
}
