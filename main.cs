using System;

class Program
{
    public static void Main(string[] args)
    {


        bool exit = false;

        while (!exit)
        {

            Console.WriteLine("Olá, seja bem-vindo!");
            Console.WriteLine("Qual das operações abaixo gostaria de realizar?");
            Console.WriteLine("  ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair da calculadora!");
            Console.WriteLine("  ");


            string escolha = Console.ReadLine();



            if (escolha == "1")
            {
                Console.WriteLine("Digite o primeiro valor: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------");

                Console.WriteLine("Digite o segundo valor: ");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------");

                Console.WriteLine("Resultado: " + (num1 + num2));
                Console.WriteLine("  ");
                Console.WriteLine("  ");
            }

            else if (escolha == "2")
            {
                Console.WriteLine("Digite o primeiro valor: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------");

                Console.WriteLine("Digite o segundo valor: ");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------");

                Console.WriteLine("Resultado: " + (num1 - num2));
                Console.WriteLine("   ");
                Console.WriteLine("   ");
            }

            else if (escolha == "3")
            {
                Console.WriteLine("Digite o primeiro valor: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------");

                Console.WriteLine("Digite o segundo valor: ");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------");

                if (num1 == 0 || num2 == 0)
                {
                    Console.WriteLine("Não é possível dividir por zero, reinicie a calculadora!");
                    return;
                }
                Console.WriteLine("Resultado: " + (num1 / num2));
                Console.WriteLine("   ");
                Console.WriteLine("   ");
            }

            else if (escolha == "4")
            {
                Console.WriteLine("Digite o primeiro valor: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------");

                Console.WriteLine("Digite o segundo valor: ");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------");

                Console.WriteLine("Resultado: " + (num1 * num2));
                Console.WriteLine("   ");
                Console.WriteLine("   ");
            }

            else if (escolha == "5")
            {
                exit = true;
                Console.WriteLine("Obrigado por utilizar esta calculadora!");
            }

            else
            {
                Console.WriteLine("Escolha uma opção válida!");
                Console.WriteLine("   ");
                Console.WriteLine("   ");
            }
        }
    }

}


