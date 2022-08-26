using System;
namespace PraticaStrutEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto mouse = new Produto(1, "mouse gamer", 45000, EProdutoType.Produto);
            var manutencaoEletrica = new Produto(2, "Manutencao residencial", 500, EProdutoType.Servico);

            mouse.Id = 40;
            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Nome);
            Console.WriteLine(mouse.Preco);
            Console.WriteLine(mouse.Type);
        }
    }
    //Struts de produtos 
    struct Produto
    {
        public Produto(int id, string nome, double preco, EProdutoType type)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Type = type;
        }
        public int Id;
        public string Nome;
        public double Preco;
        public EProdutoType Type;
        public double PrecoInDolar(double dolar)
        {
            return Preco * dolar;
        }
    }
    //Enumeradores 
    enum EProdutoType
    {
        Produto = 1,
        Servico = 2
    }
}
