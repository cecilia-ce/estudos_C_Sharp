using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioListas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ler um número inteiro N e depois os dados (id, nome e salário) de N funcionários. Não deve haver repetição de id. 
            //Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário. Para isso, o programa deve ler
            //o id e o valor de X (a porcentagem a ser aumentada). Se o id informado não existir, mostrar uma mensagem e abortar a operação.
            //Ao final mostrar a listagem atualizada dos funcionários. O salário não pode ser mudado livremente, só podendo ser 
            //aumentado com base em uma operação de aumento por porcentagem informada.
            
            Console.Write("Quandos funcionários serão registrados?");
            int n = int.Parse(Console.ReadLine());
            List<Empregado> empregados = new List<Empregado>();

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Funcionário {i+1}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                empregados.Add(new Empregado(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Informe o id do empregado que terá o salário aumentado: ");
            int idValido = int.Parse(Console.ReadLine());

            Empregado emp = empregados.Find(e => e.Id == idValido);

            if(emp != null)
            {
                Console.Write("Informe a porcentagem de aumento: ");
                double aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.AumentarSalario(aumento);
            }
            else
            {
                Console.WriteLine("Valor de id informado não existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista de empregados atualizada:");
            foreach(Empregado e in empregados)
            {
                Console.WriteLine(e);
            }







       
            

        }
    }
}
