using System;
using System.Collections.Generic;
using System.Linq;

namespace lubyincubadora
{
    class Exercicio19 // Exercício 1.9
    {
        public int[][] TransformarEmMatriz(string valor_str)
        {
            List<int> valor_nums = new List<int>();
            for (int i = 0; i < valor_str.Length; i++)
            {
                if (Char.GetNumericValue(valor_str[i]) != -1.0)
                {
                    valor_nums.Add((int)Char.GetNumericValue(valor_str[i]));
                }
            }
            int[][] matriz = new int[valor_nums.Count / 2][];
            for (int i = 0; i < valor_nums.Count/2; i++)
            {
                matriz[i] = new int[]
                {
                    valor_nums.Skip(i*2).First(),
                    valor_nums.Skip((i*2)+1).First()
                };
            }
            return matriz;
        }
    }
}
