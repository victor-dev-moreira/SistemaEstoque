using SistemaEstoque.ConsoleApp;


bool prosseguir = true;

List<Produto> produtos = new List<Produto>();

Produto product = new Produto();

int escolha;

while (prosseguir)
{
    Console.WriteLine("---------------------");
    Console.WriteLine("Controle De Estoque");
    Console.WriteLine("---------------------");

    Console.WriteLine("1 - Adicionar");
    Console.WriteLine("2 - Listar Produtos");
    Console.WriteLine("3 - Atualizar Quantidade");
    Console.WriteLine("4 - Remover Produto");
    Console.WriteLine("5 - Buscar Produtos");
    Console.WriteLine("0 - Sair");

    Console.WriteLine("---------------------");
    Console.Write("Qual Opcão? ");
    escolha = int.Parse(Console.ReadLine());

    if (escolha == 1)
    {
        Console.WriteLine("---------------------");
        Console.WriteLine("Você escolheu adicionar um produto!");
        Console.WriteLine("---------------------");

        Console.Write("Qual SKU do produto? ");
        product.Sku = int.Parse(Console.ReadLine());
        Console.Write("Qual nome do produto? ");
        product.Nome = Console.ReadLine();
        Console.Write("Qual a quantidade de estoque? ");
        product.Quantidade = int.Parse(Console.ReadLine());
        Console.Write("Qual o preco do produto? ");
        product.Preco = decimal.Parse(Console.ReadLine());

        produtos.Add(product);
    }
    else if (escolha == 2)
    {
        Console.WriteLine("Lista de Produtos");
        foreach (var produto in produtos)
        {
            Console.WriteLine(produto.Sku);
            Console.WriteLine(produto.Nome);
            Console.WriteLine(produto.Quantidade);
            Console.WriteLine(produto.Preco);
        }
        Console.ReadLine();
    }

}
