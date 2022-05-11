using System;


namespace ExercicioVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos quartos serão alugados?");
            int numQuartos = int.Parse(Console.ReadLine());

            Estudante[] estudantes = new Estudante[10];

            for(int i = 0; i < numQuartos; i++)
            {
                Console.WriteLine($"Registro de aluguel nº{i+1}:" );
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                estudantes[quarto] = new Estudante(nome, email);
                Console.WriteLine();
            }

            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if(estudantes[i] != null)
                {
                    Console.WriteLine($"{i}: {estudantes[i]}");
                }
            }

   
        }
    }
}
