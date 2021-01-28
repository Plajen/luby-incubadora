using System;
using System.Collections.Generic;

namespace lubyincubadora
{
    class Exercicio17 // Exercício 1.7
    {
        public int[] ObterElementosPares(int[] vetor_in)
        {
            List<int> lista_pares = new List<int>();
            for (int i = 0; i < vetor_in.Length; i++)
            {
                if (vetor_in[i]%2 == 0)
                {
                    lista_pares.Add(vetor_in[i]);
                }
            }
            int[] vetor_final = new int[lista_pares.Count];
            lista_pares.CopyTo(vetor_final);
            return vetor_final;
        }
    }
}
