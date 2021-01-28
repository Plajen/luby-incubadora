using System;
using System.Collections.Generic;
using System.Linq;

namespace lubyincubadora
{
    class Exercicio14 // Exercício 1.4
    {
        public int CalcularVogais(string palavra)
        {
            List<char> caracteres = new List<char>();
            List<char> vogais_string = new List<char>();
            Char[] vogais_alfabeto = {'a', 'e', 'i', 'o', 'u','A','E','I','O','U'};
            for (int i = 0; i < palavra.Length; i++)
            {
                caracteres.Add(palavra[i]);
            }
            for (int i = 0; i < caracteres.Count; i++)
            {
                if (vogais_alfabeto.Contains(caracteres[i]))
                {
                    vogais_string.Add(caracteres[i]);
                }
            }
            int qnt_vogais = vogais_string.Count;
            return qnt_vogais;
        }
    }
}
