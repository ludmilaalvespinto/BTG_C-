// See https://aka.ms/new-console-template for more information



//Criação da matriz 
char[,] tabuleiro = new char[8, 8];

//array para representar as linhas
char[] letraColuna = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };

tabuleiro[1, 0] ='1'; //peão branco
tabuleiro[1, 1] ='P';
tabuleiro[1, 2] = 'P';
tabuleiro[1, 3] = "PP;
tabuleiro[1, 4] = "PB";
tabuleiro[1, 5] = "PB";
tabuleiro[1, 6] = "PB";
tabuleiro[1, 7] = "PB";
tabuleiro[0, 0] = "TB"; // Torre
tabuleiro[0, 7] = "TB";
tabuleiro[0, 1] = "CB"; // Cavalo
tabuleiro[0, 6] = "CB";
tabuleiro[0, 2] = "BB"; // Bispo
tabuleiro[0, 5] = "BB";
tabuleiro[0, 3] = "QB"; // Rainha
tabuleiro[0, 4] = "KB"; // Rei

// Peças pretas
tabuleiro[6, 0] = "PP"; // Peão
tabuleiro[6, 1] = "PP";
tabuleiro[6, 2] = "PP";
tabuleiro[6, 3] = "PP";
tabuleiro[6, 4] = "PP";
tabuleiro[6, 5] = "PP";
tabuleiro[6, 6] = "PP";
tabuleiro[6, 7] = "PP";
tabuleiro[7, 0] = "TP"; // Torre
tabuleiro[7, 7] = "TP";
tabuleiro[7, 1] = "CP"; // Cavalo
tabuleiro[7, 6] = "CP";
tabuleiro[7, 2] = "BP"; // Bispo
tabuleiro[7, 5] = "BP";
tabuleiro[7, 3] = "QP"; // Rainha
tabuleiro[7, 4] = "KP"; // Rei

for (int linha = 2; linha < 6; linha++)
{
    for(int coluna =0; coluna < 8; coluna++)
    {
        tabuleiro[linha, coluna] = '-';
    }
}

//impressão
Console.WriteLine(" 1 2 3 4 5 6 7 8");

for(int linha = 0; linha < 8; linha++)
{
    Console.Write($"{letraColuna[linha]}");

    for (int coluna =0;coluna < 8; coluna++)
    {
        Console.Write(tabuleiro[linha, coluna] + " ");
    }
    Console.WriteLine();
}