// See https://aka.ms/new-console-template for more information
/*
 Exercício 2
    Escreva um programa que faça a leitura de 4 valores inteiros A, B, C e D. A seguir, se B for maior
    do que C e se D for maior do que A, e a soma de C com D for maior que a soma de A e B e se C
    e D, ambos, forem positivos e se a variável A for par, o programa deve escrever na saída padrão
    (“Console”) a mensagem "Valores Aceitos". Caso contrário, deve escrever "Valores Não Aceitos".
 */

Console.WriteLine("Digite o valor de A: ");
int varA = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor de B: ");
int varB = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor de C:");
int varC = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor de D: "); 
int varD = int.Parse(Console.ReadLine());

if (varB > varC && varD> varA && varC + varD > varA + varB && varC >0 && varD >0 && varA % 2 ==0)
{
    Console.WriteLine("Valores aceitos");
}
else
{
    Console.WriteLine("Valores não aceitos");
}

