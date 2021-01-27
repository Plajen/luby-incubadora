# luby-incubadora
<h1>Desafio para aprovação na vaga de estágio incubadora ASP.NET Luby</h1>

<h2>1. Lógica de Programação</h2>

<h3>1.1 Implementar função para calcular fatorial de um número:</h3>

```
using System;

namespace luby_incubadora
{
    class Program
    {

        public void CalcularFatorial(int n)
        {
            int[] fatoriais = new int[n];
            int fatorial = n;
            for (int i = 0; i <= n - 1; i++)
            {
                fatoriais[i] = n - i;
            }
            for (int i = 1; i < n-1; i++)
            {
                fatorial *= fatoriais[i];
            }
            Console.WriteLine("O resultado é:\n{0}", fatorial);
        }
        static void Main()
        {
            Console.WriteLine("Insira um número para calcular sua fatoração:");
            string x = Console.ReadLine();
            Program p = new Program();
            p.CalcularFatorial(Convert.ToInt32(x));
        }
    }
}
```
