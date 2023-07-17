// See https://aka.ms/new-console-template for more information
/*
    Exercicio 03
    Escreva um programa que faça a leitura de 5 valores Inteiros. Em seguida, o programa deve
    exibir no console a informação de quantos dos valores digitados são pares, quantos dos valores
    digitados são ímpares, quantos deles são positivos e, por fim, quantos são negativos. Cada uma
    das informações deve ser escrita em uma linha diferente.
 */

int numPar = 0;
int numImpar = 0;
int numPositivo = 0;
int numNegativo = 0;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite um número {i + 1}:");
    int numero = int.Parse(Console.ReadLine());

    if (numero % 2 == 0)
    {
        numPar++;
    }
    else
    {
        numImpar++;
    }
    if (numero > 0)
    {
        numPositivo++;
    }
    else
    {
        numNegativo++;
    }
}


Console.WriteLine($"Total de valores pares: {numPar}");
Console.WriteLine($"Total de valores ímpares: {numImpar}");
Console.WriteLine($"Total de valores positivos: {numPositivo}");
Console.WriteLine($"Total de valores negativos: {numNegativo}");

