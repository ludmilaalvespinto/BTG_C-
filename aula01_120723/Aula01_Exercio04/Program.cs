// See https://aka.ms/new-console-template for more information
/*
 Exercício 4
    Escreva um programa para calcular a área de um círculo. A área de um círculo é dada pela
    seguinte fórmula:𝐴 = 𝜋𝑟2
    O valor do raio r será digitado pelo usuário (assumir que serão digitados apenas valores
    positivos)

 */



Console.WriteLine("Digite o valor do raio do círculo: ");
double raio = double.Parse(Console.ReadLine());

if(raio > 0)
{
    double area = Math.PI * Math.Pow(raio, 2);
    Console.WriteLine("A área do círculo é: " + area);
}

else
{
    Console.WriteLine("O raio deve ser positivo! ");
}