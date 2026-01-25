string opcao;
bool exibirMenu = true;

while (exibirMenu)
{
    menuPrincipal();
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            menuClientes();
            break;
        case "2":
            menuProdutos();
            break;
        case "9":
            System.Console.WriteLine("O sistema foi encerrado!");
            exibirMenu = false;
            break;
        default:
            System.Console.WriteLine("Opção digitada inválida!");
            break;
    }
}

void menuPrincipal(){
    System.Console.WriteLine("------------------------");
    System.Console.WriteLine("Digite a opção desejada!");
    System.Console.WriteLine("------------------------");
    System.Console.WriteLine("1. Clientes");
    System.Console.WriteLine("2. Produtos");
    System.Console.WriteLine("9. Sair");
}

void menuClientes(){
    Console.Clear();
    System.Console.WriteLine("Bem-vindo ao menu de clientes!");
    System.Console.WriteLine("------------------------");
    System.Console.WriteLine("Digite a opção desejada!");
    System.Console.WriteLine("------------------------");
    System.Console.WriteLine("1. Cadastrar um novo cliente");
    System.Console.WriteLine("2. Listar os clientes");
    System.Console.WriteLine("9. Sair");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            System.Console.WriteLine("Cliente cadastrado com sucesso!");
            break;
        case "9":
            System.Console.WriteLine("Voltando ao menu principal!");
            break;
        default:
            System.Console.WriteLine("Opção digitada inválida!");
            break;
    }
}

void menuProdutos(){
    Console.Clear();
    System.Console.WriteLine("Bem-vindo ao menu de produtos!");
    System.Console.WriteLine("------------------------");
    System.Console.WriteLine("Digite a opção desejada!");
    System.Console.WriteLine("------------------------");
    System.Console.WriteLine("1. Cadastrar um novo produto");
    System.Console.WriteLine("2. Listar os produtos");
    System.Console.WriteLine("9. Sair");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            System.Console.WriteLine("Produto cadastrado com sucesso!");
            break;
        case "9":
            System.Console.WriteLine("Voltando ao menu principal!");
            break;
        default:
            System.Console.WriteLine("Opção digitada inválida!");
            break;
    }
}