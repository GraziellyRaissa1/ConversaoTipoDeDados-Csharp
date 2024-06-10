using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendizagemCSharp1
{
    internal class ConversaoDoubleParaInt
    {
        public static void Main(string[] args)
        {
            double Double = 15.75;

            int inteiro = (int) Double;  // Conversão de tipo de dado Double para Inteiro sendo uma conversão Explicita que é necessario informar o tipo de dado que deseja converter antes da conversão.

            Console.WriteLine(Double);

            Console.WriteLine(inteiro);

        }
    }
}
