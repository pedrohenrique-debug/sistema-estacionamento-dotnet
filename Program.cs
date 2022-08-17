using DESAFIOFUNDAMENTOS.Models;

bool sair = true;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");
Console.WriteLine("Digite o preço inicial");
int precoInicial = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora");
int precoHora = Convert.ToInt32(Console.ReadLine());

Estacionamento estacionamento1 = new Estacionamento(precoInicial, precoHora);

do
{
    Console.Clear();
    Console.WriteLine("Digite uma opção!");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");
    int opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            estacionamento1.CadastrarVeiculo();
            break;
        case 2:
            estacionamento1.RemoverVeiculo();

            break;
        case 3:
            estacionamento1.ListarVeiculo();
            break;
        case 4:
            sair = false;
            break;
        default:
            Console.WriteLine("Erro. Digite uma opção válida.");
            break;
    }
    Console.WriteLine("Pressione qualquer tecla para continuar:");
    string batata = Console.ReadLine();
    
} while (sair);

