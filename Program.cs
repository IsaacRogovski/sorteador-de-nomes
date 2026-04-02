SistemaSorteio sistema = new SistemaSorteio(); //Cria o Objeto sistema a partir da classe SistemaSorteio

bool rodando = true; //Define valor verdadeiro para indicar que o sistema esta rodando

while (rodando) //diz que enquanto o sistema estiver rodando continua executando
{
    Console.Clear();
    Console.WriteLine("=====Sorteio de Nomes=====");
    Console.WriteLine("\n+───Opções───+\n");
    Console.WriteLine("┌ 1 - Cadastrar Nome");
    Console.WriteLine("├ 2 - Listar Nomes");
    Console.WriteLine("├ 3 - Sortear Nomes");
    Console.WriteLine("└ 0 - Sair\n");
    Console.Write("Insira a opção que deseja: ");

    if (!int.TryParse(Console.ReadLine(), out int opcao)) // ve se o valor inserido é um inteiro
    {
        Console.Clear();
        Console.WriteLine("Insira um valor valido!\n\n");
    }
    else
    {
        switch (opcao) //switch que instancia os metodos do objeto sistema a partir do valor inserido
        {
            case 1:
                sistema.cadastrarNome();
                break;
            case 2:
                sistema.listarNomes();
                break;
            case 3:
                sistema.sortearNome();
                break;
            case 0:
                sistema.sair();
                rodando = false;
                break;
            default:
                break;
        }
    }
}