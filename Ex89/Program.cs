int num = 0, soma = 0, numNeg = 0;





for (int i = 1; i <= 4; i++)
{
    Console.Write("Digite um número: ");
    num = int.Parse(Console.ReadLine());
    if (num >= 0)
    { 
        soma = soma + num; //Acumulando 
    }
    else
    {
        numNeg = numNeg + 1; //Contando de 1 em 1
    }
}

Console.WriteLine($"A soma dos números positivos {soma}");
Console.WriteLine($"A contagem dos números negativos {numNeg}");