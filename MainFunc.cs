using System;
using System.Diagnostics;
using System.Collections.Generic;
using Exercicio11;
using Exercicio12;
using Exercicio13;

namespace MainFunc
{
    class MainFunc
    {
        static void Main()
        {
            /*Exercicio12.Exercicio12 p = new Exercicio12.Exercicio12();
            Debug.Assert(p.CalcularPremio(100, "basic", null) == 100.00);
            Debug.Assert(p.CalcularPremio(100, "vip", null) == 120.00);
            Debug.Assert(p.CalcularPremio(100, "premium", null) == 150.00);
            Debug.Assert(p.CalcularPremio(100, "special", null) == 200.00);
            Debug.Assert(p.CalcularPremio(100, "basic", 1.2) == 120.00);
            Debug.Assert(p.CalcularPremio(100, "basic", 1.4) == 140.00);
            Debug.Assert(p.CalcularPremio(100, "vip", 1.5) == 150.00);*/

            Exercicio13.Exercicio13 e13 = new Exercicio13.Exercicio13();
            Console.WriteLine(e13.ContarNumerosPrimos(20));
        }
    }
}
