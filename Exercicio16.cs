using System;
using System.Globalization;

namespace lubyincubadora
{
    class Exercicio16 // Exercício 1.6
    {
        public double CalcularDiferencaData(string data1, string data2)
        {
            var cultura = new CultureInfo("pt-BR");
            DateTime data1_convertida = DateTime.ParseExact(data1, "ddMMyyyy", cultura);
            DateTime data2_convertida = DateTime.ParseExact(data2, "ddMMyyyy", cultura);
            double diferenca_datas = (data2_convertida - data1_convertida).TotalDays;
            return diferenca_datas;
        }
    }
}
