using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roteiro4_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercício 4 – Em um município, 10 proprietários de imóveis estão em atraso com o pagamento
do imposto predial. Desenvolver um programa que calcule e imprima o valor total em atraso que
estes proprietários deverão pagar, considerando que:
• O valor do imposto e número de meses em atraso deverão ser digitados pelo usuário;
• As multas devem ser calculadas a partir do valor do imposto e de acordo com a seguinte tabela:
Valor do imposto          % por mês de atraso
Até R$ 50,00                    - 1%
De R$ 51,00 a R$ 180,00         - 2%
De R$ 181,00 a R$ 500,00        - 4%
De R$ 501,00 a R$ 1200,00       - 7%
Acima de R$ 1200,00             - 10%*/

            double imposto=0, multa=0;
            int meses=0, i;
            bool check= false;


            for (i = 0; i < 10; i++)
            {
                do
                {
                Console.Write("\nDigite o valor do imposto: ");
                imposto = double.Parse(Console.ReadLine());
                
                    if (imposto <= 0)
                    {
                        Console.WriteLine("O valor digitado é inválido.");
                        check = true;

                    }
                    else
                    {
                        Console.Write("Digite o número de meses: ");
                        meses = int.Parse(Console.ReadLine());
                        if (meses <= 0)
                        {
                            Console.WriteLine("O valor digitado é inválido.");
                            check = true;
                            
                        }
                        else
                        {
                            check = false;
                            if (imposto > 1200)
                            {
                                multa = imposto + ((imposto * 0.10) * meses);
                                Console.WriteLine("O valor total a pagar do proprietário [" + (i+1) + "]: R$" + multa);

                            }
                            else if (imposto > 500)
                            {
                                multa = imposto + ((imposto * 0.07) * meses);
                                Console.WriteLine("O valor total a pagar do proprietário [" + (i+1) + "]: R$" + multa);
                            }
                            else if (imposto > 180)
                            {
                                multa = imposto + ((imposto * 0.04) * meses);
                                Console.WriteLine("O valor total a pagar do proprietário [" + (i+1) + "]: R$" + multa);
                            }
                            else if (imposto > 50)
                            {
                                multa = imposto + ((imposto * 0.02) * meses);
                                Console.WriteLine("O valor total a pagar do proprietário [" + (i+1) + "]: R$" + multa);
                            }
                            else if (imposto > 0)
                            {
                                multa = imposto + ((imposto * 0.01) * meses);
                                Console.WriteLine("O valor total a pagar do proprietário [" + (i+1) + "]: R$" + multa);
                            }

                        }
                    }
                } while (check == true);
            }
           




        }
    }
}
