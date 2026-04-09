<<<<<<< HEAD
using SistemaEstoque.ConsoleApp;


bool prosseguir = true;

List<Produto> produtos = new List<Produto>();

Produto product = new Produto();

int escolha;
=======
﻿bool prosseguir = true;
List<Produto> produtos = new List<Produto>();
>>>>>>> 650a6a2e8c0dc8382637ce5f1b6f7d980852b377

while (prosseguir)
{
    Console.WriteLine("---------------------");
    Console.WriteLine("Controle De Estoque");
    Console.WriteLine("---------------------");

<<<<<<< HEAD
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
