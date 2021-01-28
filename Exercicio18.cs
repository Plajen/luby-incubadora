using System;
using System.Collections.Generic;

namespace lubyincubadora
{
    class Exercicio18 // Exercício 1.8
    {
        public string[] BuscarPessoa(string[] vetor_ini, string string_checar)
        {
            List<string> lista_comuns = new List<string>();
            foreach (string s in vetor_ini)
            {
                if (s.Contains(string_checar))
                {
                    lista_comuns.Add(s);
                }
            }
            string[] vetor_final = new string[lista_comuns.Count];
            lista_comuns.CopyTo(vetor_final);
            return vetor_final;
        }
    }
}
