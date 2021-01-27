using System;

namespace luby_incubadora
{
    class Program
    {

        public void CalcularPremio(float valor_premio, string tipo_premio, float? param_proprio)
        {
            if (param_proprio != null && param_proprio > 0)
            {
                valor_premio *= Convert.ToInt32(param_proprio);
                Console.WriteLine("O valor calculado do prêmio é: {0}", valor_premio);
            }
            else if (param_proprio == null)
            {
                switch (tipo_premio)
                    {
                    case "basic":
                        valor_premio *= 1;
                        break;
                    case "vip":
                        valor_premio *= 1.2f;
                        break;
                    case "premium":
                        valor_premio *= 1.5f;
                        break;
                    case "deluxe":
                        valor_premio *= 1.8f;
                        break;
                    case "special":
                        valor_premio *= 2;
                        break;
                }
                Console.WriteLine("O valor calculado do prêmio é: {0}", valor_premio);
            }
            else
            {
                Console.WriteLine("Por favor, insira um parâmetro próprio válido (positivo e inteiro).");
            }
        }
        static void Main()
        {
            Program p = new Program();
            p.CalcularPremio(100,"basic",1.9f);
        }
    }
}
