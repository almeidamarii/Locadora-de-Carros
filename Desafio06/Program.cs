using System;

namespace Desafio06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Desenvolver uma sistema de locadora onde calcula  o seguro pago do cliente , obedecendo os seguintes critérios:
            locadora();
           

        }
        enum Infomaca { CarroPopular = 1, CarroLuxo, CarroUtilitario, Sair}
        static void locadora() 
        {

            bool saida = false;

            while (saida == false) 
            {
                Console.WriteLine("Locadora de Veiculos\n");
                Console.WriteLine("\n1 - Carro Popular\n2 - Carro de Luxo\n3 - Carro Utilitario\n4 - Sair\n");
                Console.Write("Escolha um veiculo:");

                int opcao = int.Parse(Console.ReadLine());


                Infomaca opc = (Infomaca)opcao;

                if (opcao > 0 && opcao <= 4)
                {
                    switch (opc)
                    {
                        case Infomaca.CarroPopular:
                            loc locadora = new CarroPopular();
                            Console.WriteLine("Informe as diarias: ");
                            locadora.valorCarro(int.Parse(Console.ReadLine()));
                            break;
                        case Infomaca.CarroLuxo:
                            loc locadora2 = new CarroLuxo();
                            Console.WriteLine("Informe as diarias: ");
                            locadora2.valorCarro(int.Parse(Console.ReadLine()));
                            break;
                        case Infomaca.CarroUtilitario:
                            loc locadora3 = new CarroUtilitario();
                            Console.WriteLine("Informe as diarias: ");
                            locadora3.valorCarro(int.Parse(Console.ReadLine()));
                            break;
                        case Infomaca.Sair:
                            saida = true;
                            Console.Clear();
                            break;
                        default:
                            break;
                    }

                }
            


                    Console.ReadKey();
                    Console.Clear();

            }

        }
    }
}
