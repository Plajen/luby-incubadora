using System;
using System.Collections.Generic;
using System.Linq;

namespace lubyincubadora
{
    class Exercicio110 // Exercício 1.10
    {
        public int[] ObterElementosFaltantes(int[] vetor1, int[] vetor2)
        {
            List<int> lista = new List<int>();
            foreach (int i in vetor1)
            {
                if (!vetor2.Contains(i))
                {
                    lista.Add(i);
                }
            }
            foreach (int i in vetor2)
            {
                if (!vetor1.Contains(i))
                {
                    lista.Add(i);
                }
            }
            int[] vetor_final = new int[lista.Count];
            for (int i = 0; i < vetor_final.Length; i++)
            {
                vetor_final[i] = lista.ElementAt(i);
            }
            return vetor_final;
        }
    }
}
