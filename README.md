# luby-incubadora
<h1>Desafio para aprovação na vaga de estágio incubadora ASP.NET Luby</h1>

<h2>1. Lógica de Programação</h2>

<h3>1.1 Implementar função para calcular fatorial de um número:</h3>

```
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
```

<h3>1.2 Implementar função que calcula o valor total do prêmio somando fator do tipo do prêmio conforme valores:</h3>

```
        public void CalcularPremio(float valor_premio, string tipo_premio, int? param_proprio)
        {
            if (param_proprio != null && param_proprio > 0)
            {
                valor_premio *= Convert.ToInt32(param_proprio);
                Console.WriteLine("O valor calculado do prêmio é: {0}", valor_premio);
            }
            else if (param_proprio == null)
            {
                switch (tipo_premio)
                    {
                    case "basic":
                        valor_premio *= 1;
                        break;
                    case "vip":
                        valor_premio *= 1.2f;
                        break;
                    case "premium":
                        valor_premio *= 1.5f;
                        break;
                    case "deluxe":
                        valor_premio *= 1.8f;
                        break;
                    case "special":
                        valor_premio *= 2;
                        break;
                }
                Console.WriteLine("O valor calculado do prêmio é: {0}", valor_premio);
            }
        }
```

<h3>1.3 a:</h3>
