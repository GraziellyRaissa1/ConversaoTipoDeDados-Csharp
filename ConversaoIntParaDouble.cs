using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AprendizagemCSharp1
{
    internal class ConversaoIntParaDouble
    {
         public static void Main(string[] args)
        {
            int Inteiro = 9;
            double Double = Inteiro;  // Conversão do valor inteiro para Double implicita (Não precisa declarar o tipo de dado que deseja converter

            Console.WriteLine(Inteiro);
            Console.WriteLine(Double);
        }
    }
}
