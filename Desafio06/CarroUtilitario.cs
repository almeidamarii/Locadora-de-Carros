using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio06
{
    class CarroUtilitario: loc
    {
        public override void valorCarro(int dias)
        {
            float diaria = (float)400.00;
            float porcentagem = (float)0.25;
            float calculo = (diaria * dias) * porcentagem;
            Console.WriteLine($"Valor R$ 400\n Quantidade de dias: {dias}\n Valor do Seguro: {calculo.ToString("C")}");
        }
    }
}
