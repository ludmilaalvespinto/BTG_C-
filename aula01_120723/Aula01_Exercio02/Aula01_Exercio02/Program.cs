// See https://aka.ms/new-console-template for more information

/*
 Exercício 2
    Escreva um programa que faça a leitura do nome, da idade, da altura e e do peso do usuário.
    Após isso, escreva cada uma das informações em uma linha no console
 */

string nome;
int idade;
double altura;
double peso;

while (true)
{
    Console.WriteLine("Digite o seu nome, se quiser sair, digite 'sair'");
    nome = Console.ReadLine();

    if (nome.ToLower() == "sair")
        break;

    Console.WriteLine("Digite sua idade: ");
    idade = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite sua altura: ");
    altura = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite seu peso: ");
    peso = double.Parse(Console.ReadLine());

    Console.WriteLine("Suas informações são: ");
    Console.WriteLine("Nome: " + nome);
    Console.WriteLine("Idade: " + idade);
    Console.WriteLine("Altura: " + altura);
    Console.WriteLine("Peso: " + peso); 

    
}
