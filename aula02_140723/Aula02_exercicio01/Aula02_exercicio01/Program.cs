// See https://aka.ms/new-console-template for more information
/*
 Exercício 1
    Escrever um programa que faça a leitura de duas strings, converta-as para inteiro e efetue a
    sua soma, exibindo o resultado da operação no console com uma mensagem conforme no
    exemplo abaixo. Não se esqueça de adicionar tratamento de erros ao seu código.
     - "O resultado da soma de “4” com “6” é “10”"
 */
while (true) 
{ 
    Console.WriteLine("Digite o primeiro número, para realizar a soma, ou digite 'sair' para sair do programa");
    string variavel1 = Console.ReadLine();

    if (variavel1.ToLower() == "sair")
        break;

    Console.WriteLine("Digite o segundo número: ");
    string variavel2 = Console.ReadLine();

    int num1 = int.Parse(variavel1);
    int num2 = int.Parse(variavel2);


    int somaVariaveis = num1 + num2;

    Console.WriteLine($"O resultado da soma de {num1} e {num2} é {somaVariaveis}");
}