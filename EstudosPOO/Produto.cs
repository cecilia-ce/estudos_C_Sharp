using System.Globalization;

namespace EstudosPOO
{
    class Produto
    {
        //no C#, por convenção, quando se trabalha com atributos privativos (private) se utiliza o padrão de nome iniciando com anderlaine e letra minuscula. Ex: _nome
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }
        
        //o CONSTRUTOR fica, em regra, depois dos atributos. Ou seja, antes dos outros métodos. 

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = 5; // o padrão da linguagem já inicia com 0 quando não tem parâmetro, mas você pode colocar para ele iniciar com qualquer quantidade.
        }

        public string Nome //isso é uma property. Como tem lógica dentro dela, não é interessante ser substituída por auto properties
        {
            get 
            { return _nome; }
            set 
            {
                if(value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        /*public string GetNome() //versão de GET e SET não muito util no C# mas que pode ser utilizada em outras linguagens.
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            _nome = nome; 
        }*/

        /*public double Preço // essa property pode ser substituída por auto property
        {
            get { return _preco; }
        }*/

        /*public double GetPreco() //versão de GET e SET não muito util no C# mas que pode ser utilizada em outras linguagens.
        {
            return _preco;
        }*/

        /*public int Quantidade // essa property pode ser substituída por auto property
        {
            get { return _quantidade; }
        }*/

        /*public int GetQuantidade()  //versão de GET e SET não muito util no C# mas que pode ser utilizada em outras linguagens.
        {
            return _quantidade;
        }*/

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome 
                + ", $" 
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " Unidades, Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

        
         
    }
}
