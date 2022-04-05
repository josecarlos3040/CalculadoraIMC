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

            if(imc <= 18.5)
            {
                Console.WriteLine("Peso abaixo do normal");
            }
            else if ((imc > 18.5) && (imc < 25))
            {
                Console.WriteLine("Peso normal ");
            }
            else if ((imc >= 25) && (imc < 30))
            {
                Console.WriteLine("Sobre o Peso");
            }
            else if ((imc >= 30) && (imc < 35))
            {
                Console.WriteLine("1° de Obesidade");
            }
            else if ((imc >= 35) && (imc < 40))
            {
                Console.WriteLine("2° de Obesidade");
            }
            else if (imc >= 40)
            {
                Console.WriteLine("3° de Obesidade");
            }
        }
    }
}