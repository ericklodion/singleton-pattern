using System;

namespace ErickEspinosa.Singleton.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var singletonOne = Singleton.GetInstance();
            var singletonTwo = Singleton.GetInstance();

            if(singletonOne == singletonTwo)
                Console.WriteLine("Funcionou, ambas instâncias são iguais");
            else
                Console.WriteLine("Não Funcionou, as instâncias são diferentes");
        }
    }
}
