using System;

namespace Exercicio12
{
    class Exercicio12
    {
        public double CalcularPremio(double valor_premio, string tipo_premio, double? param_proprio)
        {
            if (param_proprio != null && param_proprio > 0)
            {
                valor_premio *= (double)param_proprio;
                return valor_premio;
            }
            else if (param_proprio == null)
            {
                switch (tipo_premio)
                    {
                    case "basic":
                        valor_premio *= 1;
                        break;
                    case "vip":
                        valor_premio *= 1.2;
                        break;
                    case "premium":
                        valor_premio *= 1.5;
                        break;
                    case "deluxe":
                        valor_premio *= 1.8;
                        break;
                    case "special":
                        valor_premio *= 2;
                        break;
                }
                return valor_premio;
            }
            else
            {
                return 0;
            }
        }
    }
}
