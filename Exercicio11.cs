﻿using System;

namespace lubyincubadora
{
    class Exercicio11 // Exercício 1.1
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
    }
}
