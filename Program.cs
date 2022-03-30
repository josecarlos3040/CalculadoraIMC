using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Escreva sua massa: ");
            float massa = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Escreva sua altura: ");
            float altura = Convert.ToSingle(Console.ReadLine());

            double imc = massa/(altura * altura);

            Console.WriteLine("Nome: {0}\nMassa: {1}\nAltura: {2}\nIMC: {3}", nome, massa, altura, imc);


        }
    }
}
