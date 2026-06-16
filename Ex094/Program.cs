Console.WriteLine("Exercício 94");
int A, B;
Console.WriteLine("Executar o conjunto 10 vezes: ");
for (int i = 0; i < 2; i++)

{

    Console.Write("Digite um valor inteiro para A: ");
    A = int.Parse(Console.ReadLine());
    Console.Write("Digite um valor inteiro para B: ");
    B = int.Parse(Console.ReadLine());
    Console.WriteLine($"O resto da divisão de {A} por {B} é {A % B}");

}

Console.WriteLine(" Não executar nenhuma vez; ");
for (int i = 0; i < 0; i++)

{

    Console.Write("Digite um valor inteiro para A: ");
    A = int.Parse(Console.ReadLine());
    Console.Write("Digite um valor inteiro para B: ");
    B = int.Parse(Console.ReadLine());
    Console.WriteLine($"O resto da divisão de {A} por {B} é {A % B}");

}

Console.WriteLine(" Executar o conjunto 100 vezes utilizando duas estruturas de repetição ");
for (int i = 0; i < 2; i++)

{
    for (int x = 0; x < 50; x++)
    {
        Console.Write("Digite um valor inteiro para A: ");
        A = int.Parse(Console.ReadLine());
        Console.Write("Digite um valor inteiro para B: ");
        B = int.Parse(Console.ReadLine());
        Console.WriteLine($"O resto da divisão de {A} por {B} é {A % B}");
    }
}

Console.WriteLine("Digite o número de vezes a ser executado:");
int num = int.Parse(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    Console.Write("Digite um valor inteiro para A: ");
    A = int.Parse(Console.ReadLine());
    Console.Write("Digite um valor inteiro para B: ");
    B = int.Parse(Console.ReadLine());
    Console.WriteLine($"O resto da divisão de {A} por {B} é {A % B}");
}


