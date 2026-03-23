bool prosseguir = true;
Produto p = new Produto();
List<Produto> produtos = new List<Produto>();

while (prosseguir)
{
    Console.WriteLine("---------------------");
    Console.WriteLine("Controle De Estoque");
    Console.WriteLine("---------------------");

    Console.WriteLine("1 - Cadastrar Produto");
    Console.WriteLine("2 - Mostrar Produtos Cadastrados");

    Console.Write("O que deseja fazer? ");
    int decisao = int.Parse(Console.ReadLine());

    if (decisao == 1)
    {
        Console.Clear();
        Console.WriteLine("Criando Produto");
        Console.WriteLine("---------------------");

        Console.Write("Qual nome do produto? ");
        p.Nome = (Console.ReadLine());
        Console.WriteLine("---------------------");

        Console.Write("Qual Preco do produto? ");
        p.Preco = double.Parse(Console.ReadLine());
        Console.WriteLine("---------------------");

        Console.WriteLine("Quantas unidades entre em estoque? ");
        p.Quantidade = int.Parse(Console.ReadLine());

        produtos.Add(p);

    }
    else if (decisao == 2)
    {
        foreach (Produto item in produtos)
        {
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);
        }
    }

    Console.ReadKey();

}
