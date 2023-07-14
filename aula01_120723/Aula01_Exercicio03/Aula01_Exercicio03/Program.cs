// See https://aka.ms/new-console-template for more information
/*
 Exercício 3
    Escreva um programa que faça a leitura de uma frase, que pode ser uma citação, um ditado
    ou um excerto de um texto. Ao final, escreva a frase digitada e, em uma nova linha, o número
    de caracteres desta frase.
 */

string frase;

while (true)
{
    Console.WriteLine("Olá, digite uma frase, ou se quiser sair, digite 'sair'");
    frase = Console.ReadLine();

    if (frase.ToLower() == "sair")
        break;

    Console.WriteLine("Número de caracteres é: " + frase.Length);


}
