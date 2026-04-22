using System.Net.Http.Headers;
using SistemaEstoque.ConsoleApp;


static void Main(string[] args)
{
    bool prosseguir = true;

    List<Produto> produtos = new List<Produto>();

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
            Produto novoProduto = Adicionar();
            produtos.Add(novoProduto);
        }
        else if (escolha == 2)
        {
            ListarProdutos(produtos);
            Console.ReadLine();
        }
        else if (escolha == 3)
        {
            foreach (var produto in produtos)
            {
                Console.WriteLine("---------------------");
                Console.Write($"SKU: {produto.Sku} - ");
                Console.WriteLine($"Nome: {produto.Nome}");
                Console.WriteLine($"Estoque: {produto.Quantidade}");
                Console.WriteLine("---------------------");
            }


            Console.WriteLine("---------------------");
            Console.WriteLine("1 para adicionar 2 para remover");
            Console.WriteLine("Deseja Adicionar ou Remover do Estoque? ");
            int adicionarRemover = int.Parse(Console.ReadLine());

            if (adicionarRemover == 1)
            {
                Console.Write("Qual SKU deseja alterar a quantidade?");
                int skuQuantidade = int.Parse(Console.ReadLine());

                Console.Write("Quantas você quer adicionar? ");
                int quantidadeAlterar = int.Parse(Console.ReadLine());

                foreach (var produto in produtos)
                {
                    if (produto.Sku == skuQuantidade)
                    {
                        produto.Quantidade = produto.Quantidade + quantidadeAlterar;
                    }
                }
            }
            else
            {
                Console.Write("Qual SKU deseja alterar a quantidade?");
                int skuQuantidade = int.Parse(Console.ReadLine());

                Console.Write("Quantas você quer remover? ");
                int quantidadeAlterar = int.Parse(Console.ReadLine());

                foreach (var produto in produtos)
                {
                    if (produto.Sku == skuQuantidade)
                    {
                        produto.Quantidade = produto.Quantidade - quantidadeAlterar;
                    }
                }
            }

        }
        else if (escolha == 4)
        {
            Console.WriteLine("Qual SKU deseja remover? ");
            int removeSku = int.Parse(Console.ReadLine());

            Produto produtoRemover = produtos.Find(p => p.Sku == removeSku);

            if (produtoRemover != null)
            {
                produtos.Remove(produtoRemover);
                Console.WriteLine("Produto Removido!");
            }
            else
            {
                Console.WriteLine("Produto Não Encontrado");
            }
        }
    }


    static Produto Adicionar()
    {


        Produto product = new Produto();
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

        return product;
    }

    static void ListarProdutos(List<Produto> produtos)
    {
        Console.WriteLine("Lista de Produtos");
        foreach (var produto in produtos)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine($"SKU: {produto.Sku} - ");
            Console.WriteLine($"Nome: {produto.Nome}");
            Console.WriteLine($"Estoque: {produto.Quantidade}");
            Console.WriteLine($"Preco: {produto.Preco}");
            Console.WriteLine("---------------------");
        }

    }
}
