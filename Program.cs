using System;

namespace Pesquisa_de_Usuário
{
    class Program
    {
        static void Main(string[] args)
        {
            string n1;

            string n2;

            int n3;

            Console.WriteLine("Digite seu Nome");
            n1 = Console.ReadLine();

            Console.WriteLine("Digite sua Idade");
            n2 = Console.ReadLine();

            Console.WriteLine("Digite seu Peso");
            n3 = int.Parse(Console.ReadLine());

            string nome = "Seu Nome é : " + n1;

            string idade = "Sua Idade é : " + n2;

            string peso = "Seu Peso é : " + n3;

            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(peso);

            Console.ReadLine();


            Console.WriteLine(" Uau vejo aqui que você é uma ótima pessoa !!!");
            Console.WriteLine(" Obrigado por participar da minha pesquisa !");

            Console.ReadLine();

            Console.WriteLine("Avalie minha pesquisa digitando um número de 0 a 10. ");
            
            var p1 = int.Parse(Console.ReadLine());

            if (p1 >= 8)            

            { Console.WriteLine(" Muito Obrigado "); }
           
            if ( p1 >= 6 )

            { Console.WriteLine("  Obrigado "); }

            if ( p1 >4)

            { Console.WriteLine(" Valeu "); }

             else

             { Console.WriteLine("  Desculpe vou melhor estou aprendendo ! "); }
            
                  
                      


        }
    }
}
