using System;
using System.Collections.Generic;

namespace Exercicio13
{
    class Exercicio13
    {
        public int ContarNumerosPrimos(int n)
        {
            int[] numeros = new int[n];
            List<int> primos = new List<int>();
            int qnt_primos = 0;
            for (int i = 0; i <= n - 1; i++)
            {
                numeros[i] = n - i;
            }
            for (int i = 0; i < n; i++)
            {
                if (numeros[i] == 2 || numeros[i] == 5 || numeros[i] == 3 || numeros[i] == 7)
                {
                    primos.Add(numeros[i]);
                }
                else if (numeros[i] > 1 && numeros[i]%2 != 0 && numeros[i]%5 != 0 && numeros[i]%3 != 0 && numeros[i]%7 != 0)
                {
                    primos.Add(numeros[i]);
                }
            }
            qnt_primos = primos.Count;
            return qnt_primos;
        }
    }
}
