// See https://aka.ms/new-console-template for more information
/*
 Exercício 4
    Escreva um programa que faça a leitura da nota de um aluno, que pode variar de 0 a 10, com
    até duas casas decimais. Em seguida, o programa deve exibir o “Conceito” de aproveitamento
    do aluno na disciplina. O conceito é dado de acordo com a tabela a seguir.
    (olhar tabela do arquivo)
 */

Console.WriteLine("Escreva a nota do aluno(a): ");
float nota = float.Parse(Console.ReadLine());

string conceito = null;

if (nota <=10.00 && nota >= 8.00)
{
    conceito = "Ótimo";
}
else if (nota <= 7.99 && nota >= 6.00)
{
    conceito = "Bom";
}
else if (nota <= 5.99 && nota >= 4.00)
{
    conceito = "Regular";
}
else
{
    conceito = "Péssimo";
}

Console.WriteLine($"Sua nota foi {nota} e o conceito {conceito}");
