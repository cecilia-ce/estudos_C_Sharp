using System;
using System.Globalization;
using System.Collections.Generic; //namespace usado para poder utilizar as listas (List)

namespace EstudosPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            //exercício 1: produtos de um estoque
            /*        
            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos que serão adicionados ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos que serão removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine("Dados atualizados: " + p);

            p.Nome = "T";
            Console.WriteLine(p.Nome);
            */


            //EXERCÍCIO 2: ler os valores da largura e altura de um retângulo. Mostrar na tela o valor de sua área, perímetro e diagonal
            /*
            Retangulo r = new Retangulo();
            Console.WriteLine("Digite a largura e a altura do retângulo: ");
            Console.Write("Largura: ");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = r.Area();
            double perimetro = r.Perimetro();
            double diagonal = r.Diagonal();

            Console.WriteLine("ÁREA: " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO: " + perimetro.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL: " + diagonal.ToString("F2", CultureInfo.InvariantCulture));
            */

            //EXERCICIO 3
            /*
            Console.Write("DIgite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
            */

            //EXERCÍCIO 4: Conversor de moeda
            /*
            Console.WriteLine("Qual a cotação do dolar?");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantos dólares você vai comprar?");
            double dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double valorReais = ConversorDeMoeda.Conversor(cotacao, dolares);
            Console.WriteLine("Valor a ser pago em reais: " + valorReais.ToString("F2", CultureInfo.InvariantCulture));
            */

            //INICIALIZANDO E CRIANDO STRUCT 
            /*
            Point p;   // como ele é um tipo valor, basta atribuir os valores pra X e Y. Não precisa fazer o "new" como acontece com as classes na hora de instanciar o objeto.
            p.X = 10;  // mas o tipo struct também aceita o comando "new".
            p.Y = 20;
            
            Console.WriteLine(p);
            */

            //VETORES E ARRANJOS
            /*
            Console.WriteLine("Digite um número:");
            int n = int.Parse(Console.ReadLine());
            double[] alturas = new Double[n];
            double soma = 0;
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite uma altura:");
                alturas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                soma += alturas[i];
            }

            double media = soma / n;
            Console.WriteLine("A média das alturas é: " + media.ToString("F2", CultureInfo.InvariantCulture));
            */
            /*
            Console.WriteLine("Digite um número:");
            int numero = int.Parse(Console.ReadLine());
            Produto2[] produtos = new Produto2[numero];


            for(int i=0; i<numero; i++)
            {
                Console.Write("Nome do produto: ");
                string nome = Console.ReadLine();
                Console.Write("Preco do produto: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                produtos[i] = new Produto2(nome, preco);
            }

            double soma = 0.0;
            for(int i = 0; i<numero; i++)
            {
                soma += produtos[i].Preco;
            }

            double media = soma / numero;

            Console.WriteLine("PREÇO MÉDIO: " + media.ToString("F2", CultureInfo.InvariantCulture));

            foreach(Produto2 prod in produtos)
            {
                Console.WriteLine(prod.Nome);
                Console.WriteLine(prod.Preco);
            }
            */

            //MODIFICADOR DE PARÂMETRO >> quando você pode receber um número variado de parâmetro que você desconhece, pode utilizar o "params" da seguinte forma:
            /*
            int s1 = Calculator.Soma(1, 2, 8, 9, 4, 5);
            Console.WriteLine(s1);
            */

            List<string> list = new List<string>(); //criou uma lista vazia. Porém a linguagem C# já permite que se crie uma lista, instancie e já coloque elementos nela.
            List<string> list2 = new List<string> { "Maria", "José", "Kleber", "Otaviano", "João", "Jaciara" }; //criando lista e já atribuindo valores para ela. 

            //Desvantagem da Lista é que, de modo geral, o acesso aos elementos é sequencial. Entretanto, as implementações de listas são otimizadas, uma vez que o acesso dela vai ser
            //parecido com o acesso do vetor. 




        }
    }
}
