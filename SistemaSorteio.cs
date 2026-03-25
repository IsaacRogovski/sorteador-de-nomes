// using System.Text.Json;

public class SistemaSorteio 
{
    public List<string> nomes = new List<string>(); //cria o objeto de uma lista (quase um array)
    public Random random = new Random(); //cria o objeto pra manipulação de numeros aleatórios

    public void cadastrarNome()
    {
        bool isNomeInserido = false; //Define o valor falso, que indica que ainda nao foram inseridos todos os nomes
        while (!isNomeInserido) //só vai parar caso o valor seja verdadeiro
        {
            Console.Clear();
            Console.WriteLine("Opção selecionada: Cadastrar nome");
            Console.WriteLine("Digite o nome a ser cadastrado:");
            string? nome = Console.ReadLine(); //detalhe interessante, o string? permite que o valor seja null
            if (!string.IsNullOrWhiteSpace(nome)) //metodo bem autoexplicativo, e o if para validar apenas se nao for null ou ""
            {
                Console.Clear();
                nomes.Add(nome); //adiciona o nome inserido à lista nomes
                Console.WriteLine($"{nome} foi adicionado ao sistema");
                Console.WriteLine("Deseja cadastrar outro nome? (S/N):");
                string? simOuNao = Console.ReadLine();

                if (simOuNao?.ToLower() == "s") //se sim, quer dizer que ele quer inserir mais um nome
                {
                    Console.Clear();
                }
                else
                {
                    isNomeInserido = true; //deixa true e finaliza o loop, fazendo voltar ao inicio
                    Console.Clear();
                    Console.WriteLine("Voltando ao Inicio..");
                    Thread.Sleep(1000);
                }
            }
            else //else para dizer que o valor do nome inserido é null ou ""
            {
                Console.Clear();
                Console.WriteLine("Insira um valor valido!");
                Thread.Sleep(1000);
            }
        }
    }

    public void listarNomes()
    {
        Console.Clear();
        Console.WriteLine("Opção selecionada: Listar nomes inseridos: \n");
        int i = 1;
        foreach (string nome in nomes) //foreach que lista todos os valores da lista nomes
        {
            Console.WriteLine($"{i} - {nome}");
            i++;
        }
        Console.WriteLine("\nPressione enter para voltar ao Inicio:");
        Console.Read();
    }

    public void sortearNome()
    {
        Console.Clear();
        if (nomes.Count > 1) //verifica se tem ao menos 2 valor na lista
        {
            bool sorteioRodando = false; //Define o valor falso, que indica que o sorteio ainda esta rodando
            while (!sorteioRodando) //enquanto for false vai estar rodando
            {
                Console.Clear();
                Console.WriteLine("Opção selecionada: Sortear Nomes \n");
                int i = random.Next(0, nomes.Count); // i vai ser um numero aleatorio de 0 ate o length da lista nomes
                Console.WriteLine($"Nome sorteado: {nomes[i]}\n");
                Console.WriteLine("Deseja sortear outro nome? (S/N):");
                string? simOuNao = Console.ReadLine();

                if (simOuNao?.ToLower() == "s") //se sim, quer dizer que ele quer sortear outro nome
                {

                    Console.WriteLine("Deseja retirar o nome sorteado? (S/N):");
                    simOuNao = Console.ReadLine();

                    if (simOuNao?.ToLower() == "s") //se sim, quer dizer que ele quer tirar o nome que acabou de ser sorteado
                    {
                        if (nomes.Count <= 2) // se neste momento, a lista tiver 2 ou menos valores nao deixa remover o ultimo sorteado
                        {
                            Console.WriteLine("A quantidade de nomes adicionados é o limite para o funcionamento do sorteio.");
                            Thread.Sleep(1000);
                        }
                        else 
                        {
                            nomes.RemoveAt(i); // tira o nome que foi sorteado
                        }
                    }
                } 
                else //else que diz que ele não quer sortear outro nome
                {
                    sorteioRodando = true; // deixa true para sair do loop, e voltar ao inicio
                    Console.Clear();
                    Console.WriteLine("Voltando ao Inicio..");
                    Thread.Sleep(1000);
                }
            }
        }
        else // se quando ele tentar sortear tiver menos de 2 nomes, nao deixa
        {
            Console.WriteLine("Insira ao menos 2 nomes antes de sortear!");
            Thread.Sleep(1500);
        }
    }

    public void sair()
    {
        Console.Clear();
        Console.WriteLine("\nSAINDO\n");
    }

}