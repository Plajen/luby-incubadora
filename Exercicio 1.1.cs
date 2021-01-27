using System;
using System.Diagnostics;

namespace luby_incubadora
{
    class Exercicio11
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
        static void Main()
        {
            Exercicio11 p = new Exercicio11();
            Debug.Assert(p.CalcularPremio(100, "basic", null) == 100.00);
            Debug.Assert(p.CalcularPremio(100, "vip", null) == 120.00);
            Debug.Assert(p.CalcularPremio(100, "premium", null) == 150.00);
            Debug.Assert(p.CalcularPremio(100, "special", null) == 200.00);
            Debug.Assert(p.CalcularPremio(100, "basic", 1.2) == 120.00);
            Debug.Assert(p.CalcularPremio(100, "basic", 1.4) == 140.00);
            Debug.Assert(p.CalcularPremio(100, "vip", 1.5) == 150.00);
        }
    }
}
