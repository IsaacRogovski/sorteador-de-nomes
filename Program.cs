bool rodando = true;

List<string> nomes = new List<string>();
Random random = new Random();


while (rodando)
{
    Console.Clear();
    Console.WriteLine("\n=====Sorteio de Nomes=====");
    Console.WriteLine("\n\n--Opções--\n");
    Console.WriteLine("1 - Cadastrar Nome");
    Console.WriteLine("2 - Listar Nomes");
    Console.WriteLine("3 - Sortear Nomes");
    Console.WriteLine("0 - Sair\n");
    Console.WriteLine("Insira a opção que deseja:");

    if (!int.TryParse(Console.ReadLine(), out int opcao))
    {
        Console.Clear();
        Console.WriteLine("Insira um valor valido!\n\n");
        Thread.Sleep(1000);
    }
    else
    {
        switch (opcao)
        {
            case 1:
                cadastrarNome();
                break;
            case 2:
                listarNomes();
                break;
            case 3:
                sortearNome();
                break;
            case 0:
                sair();
                break;
            default:
                Console.WriteLine("Opção inválida. Por favor, selecione uma opção válida.");
                break;
        }
    }
}

void cadastrarNome()
{
    bool isNomeInserido = false;
    while (!isNomeInserido)
    {
        Console.Clear();
        Console.WriteLine("Opção selecionada: Cadastrar nome");
        Console.WriteLine("Digite o nome a ser cadastrado:");
        string? nome = Console.ReadLine();
        if (nome != null && nome.Length > 0)
        {
            Console.Clear();
            nomes.Add(nome);
            Console.WriteLine(nome + " foi adicionado ao sistema");
            Console.WriteLine("Deseja cadastrar outro nome? (S/N):");
            string? simOuNao = Console.ReadLine();

            if (simOuNao != null && simOuNao.Length == 1 && simOuNao.ToLower() == "s")
            {
                Console.Clear();
            }
            else
            {
                isNomeInserido = true;
                Console.Clear();
                Console.WriteLine("Voltando ao Inicio..");
                Thread.Sleep(1000);
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Insira um valor valido!");
            Thread.Sleep(1000);
        }
    }
}

void listarNomes()
{
    Console.Clear();
    Console.WriteLine("Opção selecionada: Listar nomes inseridos: \n");
    int i = 1;
    foreach (string nome in nomes)
    {
        Console.WriteLine(i + " - " + nome);
        i++;
    }
    Console.WriteLine("\nPressione enter para voltar ao Inicio:");
    Console.Read();
}

void sortearNome()
{
    Console.Clear();
    if (nomes.Count != 0)
    {
        Console.WriteLine("Opção selecionada: Sortear Nomes \n");
        int i = random.Next(0, nomes.Count);
        Console.WriteLine("Nome sorteado: " + nomes[i]);
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Insira ao menos 2 nomes antes de sortear!");
        Thread.Sleep(1500);
    }
}

void sair()
{
    Console.Clear();
    Console.WriteLine("\nSAINDO\n");
    rodando = false;
}