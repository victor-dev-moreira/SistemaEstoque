bool prosseguir = true;
List<Produto> produtos = new List<Produto>();

while (prosseguir)
{
    Console.WriteLine("---------------------");
    Console.WriteLine("Controle De Estoque");
    Console.WriteLine("---------------------");

    Console.WriteLine("1 - Cadastrar Produto");
    Console.WriteLine("2 - Mostrar Produtos Cadastrados");
    Console.WriteLine("3 - Deduzir Estoque");

    Console.Write("O que deseja fazer? ");
    int decisao = int.Parse(Console.ReadLine());

    if (decisao == 1)
    {
        Produto p = new Produto();
        //Console.Clear();
        Console.WriteLine("Criando Produto");
        Console.WriteLine("---------------------");

        Console.Write("Qual nome do produto? ");
        p.Nome = (Console.ReadLine());
        Console.WriteLine("---------------------");

        Console.Write("Qual Preco do produto? ");
        p.Preco = double.Parse(Console.ReadLine());
        Console.WriteLine("---------------------");

        Console.Write("Quantas unidades entra em estoque? ");
        p.Quantidade = int.Parse(Console.ReadLine());

        produtos.Add(p);


    }
    else if (decisao == 2)
    {
        //Console.Clear();
        Console.WriteLine("Produtos: ");
        Console.WriteLine("---------------------");

        foreach (Produto produto in produtos)
        {

            Console.WriteLine($"Produto: {produto.Nome}");
            Console.WriteLine($"Preco: {produto.Preco}");
            Console.WriteLine($"Quantidade: {produto.Quantidade}");
            Console.WriteLine("---------------------");

        }
        Console.ReadKey();

    }
    else if (decisao == 3)
    {
        Console.WriteLine("---------------------");
        Console.WriteLine("Retirar Quantidade Do Estoque");
        Console.Write("Qual item você deseja retirar do Estoque? ");
        string produtoDeduzir = Console.ReadLine();

        Console.WriteLine("---------------------");
        Console.Write("Quantas unidades deseja deduzir? ");
        int deduzQuantidade = int.Parse(Console.ReadLine());

        foreach (Produto produto in produtos)
        {
            if (produto.Nome == produtoDeduzir)
            {
                produto.Quantidade = produto.Quantidade - deduzQuantidade;
            }
        }

    }
    //Console.Clear();
}
