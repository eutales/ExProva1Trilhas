Console.WriteLine("Hello, World!");
double totalAlunos = 0, grupoA = 0, grupoB = 0, grupoC = 0;

Console.Write("Quantas vezes você frequenta o restaurante? ");
double numero = int.Parse(Console.ReadLine());

while (numero > -1)
{
    totalAlunos++;
    if (numero < 10)
    {
        grupoA++;
    }else if (numero <= 15)
    {
        grupoB++;
    }
    else
    {
        grupoC++;
    }
    Console.Write("Quantas vezes você frequenta o restaurante? ");
    numero = int.Parse(Console.ReadLine());
}

double RGrupoA = (grupoA / totalAlunos) * 100;
double RGrupoB = (grupoB / totalAlunos) * 100;
double RGrupoC = (grupoC / totalAlunos) * 100;

Console.WriteLine($" Grupo A: {RGrupoA}%, Grupo B: {RGrupoB}%, Grupo C: {grupoC}%");



