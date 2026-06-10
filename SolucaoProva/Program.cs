using System.Diagnostics;

int livrosComunitaria = 5, livrosCentral = 10;
int livrosAtual = 0, livrosSecundario = 0, optGeral = 0, optAtual = 0;
string nomeAtual = "", nomeSecundario = "";

while (optGeral != 3)
{

    Console.Clear();
    Console.WriteLine("----- SELECIONE A BIBLIOTECA -----");
    Console.WriteLine("----- 1 CENTRAL              ------");
    Console.WriteLine("----- 2 COMUNITÁRIA          ------");
    Console.WriteLine("----- 3 ENCERRAR             ------");
    Console.Write("----- Digite: ");
    optGeral = int.Parse(Console.ReadLine());

    switch (optGeral)
    {
        case 1:
            //Biblioteca Central
            nomeAtual = "CENTRAL";
            nomeSecundario = "COMUNITÁRIA";
            livrosAtual = livrosCentral;
            livrosSecundario = livrosComunitaria;

            break;
        case 2:
            //Biblioteca Comunitária
            nomeAtual = "COMUNITÁRIA";
            nomeSecundario = "CENTRAL";
            livrosAtual = livrosComunitaria;
            livrosSecundario = livrosCentral;

            break;
        case 3:

            //Sair 
            Console.Clear();
            Console.WriteLine("OBRIGADO POR USAR O NOSSO PROGRAMA! APERTE QUALQUER TECLA PARA SAIR");
            Console.ReadKey();
            break;
        default:
            Console.Clear();
            Console.WriteLine("Número inválido! Aperte enter para digitar novamente.");
            Console.ReadKey();
            break;

    }

    Console.Clear();

    if (optGeral == 3)
    {
        //Sair do programa
    }
    else
    {

        while (optAtual != 5)
        {


            Console.WriteLine($"--- BEM VINDO A BIBLIOTECA {nomeAtual}! --");
            Console.WriteLine($"--- QUANTIDADE ATUAL DE LIVROS: {livrosAtual} Livros --");
            Console.WriteLine($"---                                                  --");
            Console.WriteLine($"--- SELECIONE UMA OPÇÃO:                             --");
            Console.WriteLine($"--- 1 INSERIR LIVROS                                 --");
            Console.WriteLine($"--- 2 RETIRAR LIVROS                                 --");
            Console.WriteLine($"--- 3 CONSULTAR ESTOQUE DE LIVROS                    --");
            Console.WriteLine($"--- 4 TRANSFERIR PARA A BIBLIOTECA {nomeSecundario}  --");
            Console.WriteLine($"--- 5 TROCAR BIBLIOTECA                              --");
            Console.Write($"--- DIGITE: ");
            optAtual = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (optAtual)
            {
                case 1:
                    Console.WriteLine($"Quantos livros você deseja adicionar a BIBLIOTECA {nomeAtual} ?");
                    int qtdeInserir = int.Parse(Console.ReadLine());
                    if (qtdeInserir > 0)
                    {
                        livrosAtual = livrosAtual + qtdeInserir;

                        if (nomeAtual == "CENTRAL")
                        {
                            livrosCentral = livrosAtual;
                            qtdeInserir = 0;

                        }
                        else if (nomeAtual == "COMUNITÁRIA")
                        {
                            livrosComunitaria = livrosAtual;
                            qtdeInserir = 0;
                        }
                        Console.Clear();
                        Console.WriteLine($"LIVROS INSERIDOS COM SUCESSO, TOTAL DE LIVROS {livrosAtual}.");
                        Console.WriteLine($"APERTE QUALQUER TECLA PARA RETORNAR.");
                        Console.ReadKey();

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Número inválido");
                    }
                    break;

                case 2:
                    Console.WriteLine($"Quantos livros você deseja remover a BIBLIOTECA {nomeAtual} ?");
                    int qtdeRemover = int.Parse(Console.ReadLine());
                    if ((qtdeRemover > 0) && (qtdeRemover <= livrosAtual))
                    {
                        livrosAtual = livrosAtual - qtdeRemover;

                        if (nomeAtual == "CENTRAL")
                        {
                            livrosCentral = livrosAtual;
                            qtdeRemover = 0;

                        }
                        else if (nomeAtual == "COMUNITÁRIA")
                        {
                            livrosComunitaria = livrosAtual;
                            qtdeRemover = 0;
                        }
                        Console.Clear();
                        Console.WriteLine($"LIVROS REMOVIDOS COM SUCESSO, TOTAL DE LIVROS {livrosAtual}.");
                        Console.WriteLine($"APERTE QUALQUER TECLA PARA RETORNAR.");
                        Console.ReadKey();

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Número inválido, ou quantidade de livros insuficiente;");
                    }
                    break;
                case 3:

                    Console.Clear();
                    Console.WriteLine($"LIVROS NA BIBLIOTE {nomeAtual}: {livrosAtual}");
                    Console.WriteLine($"LIVROS NA BIBLIOTE {nomeSecundario}: {livrosSecundario}");
                    Console.WriteLine($"APERTE QUALQUER TECLA PARA RETORNAR.");
                    Console.ReadKey();

                    break;

                case 4:

                    Console.Clear();
                    Console.WriteLine($"Quantos livros você deseja transferir para a BIBLIOTECA {nomeSecundario}?");
                    int transferir = int.Parse(Console.ReadLine());

                    if (transferir > 0 && (transferir <= livrosAtual))
                    {
                        livrosAtual = livrosAtual - transferir;
                        livrosSecundario = livrosSecundario + transferir;

                        if (nomeAtual == "CENTRAL")
                        {
                            livrosCentral = livrosAtual;
                            transferir = 0;

                        }
                        else if (nomeAtual == "COMUNITÁRIA")
                        {
                            livrosComunitaria = livrosAtual;
                            transferir = 0;
                        }

                        Console.Clear();
                        Console.WriteLine($"LIVROS TRANSFERIDOS COM SUCESSO, TOTAL DE LIVROS {livrosAtual}.");
                        Console.WriteLine($"APERTE QUALQUER TECLA PARA RETORNAR.");
                        Console.ReadKey();
                        Console.Clear();

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Número inválido, ou quantidade de livros insuficiente;");
                    }

                    break;

            }


        }
    }
    optAtual = 0;

}


