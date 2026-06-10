Console.WriteLine("Exemplo Menu");
int opt = 5;
while (opt != 0)
{
    Console.WriteLine("Banco Trilhas!");
    Console.WriteLine("---------------");
    Console.WriteLine("- 1 SAQUE    --");
    Console.WriteLine("- 2 DEPÓSITO --");
    Console.WriteLine("- 3 SALDO    --");
    Console.WriteLine("- 0 SAIR     --");
    Console.Write("- DIGITE:");
    opt = int.Parse(Console.ReadLine());
    Console.Clear();

    switch (opt)
    {
        case 1:
            Console.WriteLine("Executando operações de saque, enter para sair: ");
            Console.ReadKey();
            Console.Clear();
            break;
        case 2:
            Console.WriteLine("Executando operações de depósito");
            Console.ReadKey();
            Console.Clear();
            break;
        case 3:
            Console.WriteLine("Executando operações de saldo");
            Console.ReadKey();
            Console.Clear();
            break;
        case 0:
            Console.WriteLine("Obrigado por utilizar nossos serviços!");
            Console.ReadKey();
            Console.Clear();
            break;

        default:
            Console.WriteLine("Valor informado inválido");
            Console.ReadKey();
            Console.Clear();
            break;
    }
}

