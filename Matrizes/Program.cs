int[,] matriz = new int[3,3];
int[,] matriz2 = new int[3, 3];
int[,] matriz_soma = new int[3, 3];

for (int linha = 0; linha < 3; linha++)
{
    for (int coluna = 0; coluna < 3; coluna++)
    {
        
        matriz2[linha, coluna] = new Random().Next(1,20);
     
        matriz[linha, coluna] = new Random().Next(1, 20);
    }
}

for (int linha = 0; linha < 3; linha++)
{
    for (int coluna = 0; coluna < 3; coluna++)
    {
        matriz_soma[linha,coluna] = matriz[linha, coluna] + matriz2[linha, coluna];
    }
    Console.WriteLine();
}
Console.WriteLine("Matriz 1");
for (int linha = 0; linha < 3; linha++)
{
    for (int coluna = 0; coluna < 3; coluna++)
    {
        Console.Write(matriz[linha, coluna] + " ");
    }
    Console.WriteLine();
}Console.WriteLine("Matriz 2");
for (int linha = 0; linha < 3; linha++)
{
    for (int coluna = 0; coluna < 3; coluna++)
    {
        Console.Write(matriz2[linha, coluna] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Soma das matrizes");
Console.WriteLine();
for (int linha = 0; linha < 3; linha++)
{
    for (int coluna = 0; coluna < 3; coluna++)
    {
        Console.Write(matriz_soma[linha,coluna] + " ");
    }
    Console.WriteLine();
}