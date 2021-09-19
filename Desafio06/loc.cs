using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio06
{
    class loc
    {
        public virtual void valorCarro(int dias)
        {
            float diaria = (float)100.00;
            float porcentagem = (float)0.1;
            float calculo = (diaria * dias) * porcentagem;
            Console.WriteLine($"Valor R$ 100\n Quantidade de dias: {dias}\n Valor do Seguro: {calculo.ToString("C")}");
        }
    }
}
