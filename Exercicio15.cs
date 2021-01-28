using System;
using System.Collections.Generic;

namespace lubyincubadora
{
    class Exercicio15 // Exercício 1.5
    {
        public string CalcularValorComDescontoFormatado(string valor_str, string desconto_str)
        {
            double valor_double = 0;
            List<double> valor_nums = new List<double>();
            double desconto_double = 0;
            List<double> desconto_nums = new List<double>();
            for (int i = 0; i < valor_str.Length; i++)
            {
                if (Char.GetNumericValue(valor_str[i]) != -1.0)
                {
                    valor_nums.Add(Char.GetNumericValue(valor_str[i]));
                }
            }
            foreach (int entrada in valor_nums)
            {
                valor_double = 10 * valor_double + entrada;
            }
            for (int i = 0; i < desconto_str.Length; i++)
            {
                if (Char.GetNumericValue(desconto_str[i]) != -1.0)
                {
                    desconto_nums.Add(Char.GetNumericValue(desconto_str[i]));
                }
            }
            foreach (int entry in desconto_nums)
            {
                desconto_double = 10 * desconto_double + entry;
            }
            valor_double /= 100;
            desconto_double /= 100;
            double valor_final = valor_double - (valor_double * desconto_double);
            string string_valor_final = (valor_final).ToString("C");
            return string_valor_final;
        }
    }
}
