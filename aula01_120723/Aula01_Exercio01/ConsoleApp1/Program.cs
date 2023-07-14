// See https://aka.ms/new-console-template for more information

/* 
 Exercício 1
    Escreva um programa que faça a leitura do nome do usuário e imprima uma saudação no
    console usando o nome digitado.
 
 */

/*

    Console.WriteLine("Olá, escreva seu nome: ");
    var nome = Console.ReadLine();

    Console.WriteLine("Olá, " + nome + "! Seja bem vindo(a)!");
*/


string nome;

do
{
    Console.WriteLine("Olá, escreva seu nome, caso queira sair, digite 'sair' ");
    nome = Console.ReadLine();

    if (nome.ToLower() != "sair")
    {
        Console.WriteLine("Olá, " + nome + "Seja bem vindo(a)!");
    }
} while (nome.ToLower() != "sair");