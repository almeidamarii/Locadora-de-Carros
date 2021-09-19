using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio06
{
    class CarroLuxo : loc
    {
        public override void valorCarro(int dias)
    {
            float diaria = (float)300.00;
            float porcentagem = (float)0.2;
            float calculo = (diaria * dias) * porcentagem;
            Console.WriteLine($"Valor R$ 300\n Quantidade de dias: {dias}\n Valor do Seguro: {calculo.ToString("C")}");
        }
    }
}

