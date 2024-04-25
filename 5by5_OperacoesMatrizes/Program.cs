/* Faça um programa que gere duas matrizes e faça as 4 operações básicas nelas
    adicionar:
    a) Função de menu de seleção da operação
	b) Função de sorteio da matriz
	c) Função que cria a matriz passando 2 parametros (linha, coluna)
*/

int qtdLinhas = 5, qtdColunas = 5;
float[,] matriz1;
float[,] matriz2;
float[,] resultado;
int operacao;
int option;

int MenuOperacao()
{
    int op;
    do
    {
        Console.WriteLine("\n\nSelecione a operação desejada:");
        Console.WriteLine("1 - Adição");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        op = int.Parse(Console.ReadLine());
    } while (op < 1 || op > 4);

    return op;
}

float[,] CriarMatriz(int maxLinha, int maxColuna)
{
    return new float[maxLinha, maxColuna];
}

void GerarValores(float[,] matriz, int min, int max, int maxLinhas, int maxColunas)
{
    for (int linha = 0; linha < maxLinhas; linha++)
    {
        for (int coluna = 0; coluna < maxColunas; coluna++)
        {
            matriz[linha, coluna] = new Random().Next(min, max);
        }
    }
}

float[,] CalcularMatriz(float[,] m1, float[,] m2, int op, int maxLinhas, int maxColunas)
{
    float[,] res = CriarMatriz(maxLinhas, maxColunas);
    // Operando as matrizes
    for (int linha = 0; linha < maxLinhas; linha++)
    {
        for (int coluna = 0; coluna < maxColunas; coluna++)
        {
            switch (op)
            {
                // Soma
                case 1:
                    res[linha, coluna] = m1[linha, coluna] + m2[linha, coluna];
                    break;

                // Subtração
                case 2:
                    res[linha, coluna] = m1[linha, coluna] - m2[linha, coluna];
                    break;

                // Multiplicação
                case 3:
                    res[linha, coluna] = m1[linha, coluna] * m2[linha, coluna];
                    break;

                // Divisão
                case 4:
                    if (m2[linha, coluna] != 0)
                        res[linha, coluna] = m1[linha, coluna] / m2[linha, coluna];
                    else
                        res[linha, coluna] = float.NaN;
                    break;
                default:
                    res[linha, coluna] = float.NaN;
                    break;
            }
        }
    }

    return res;
}

void ImprimirMatriz(float[,] matriz, string titulo, int maxLinhas, int maxColunas)
{
    Console.Write("\n\n"+titulo);
    for (int linha = 0; linha < maxLinhas; linha++)
    {
        Console.WriteLine();
        for (int coluna = 0; coluna < maxColunas; coluna++)
        {
            Console.Write(matriz[linha, coluna] + " ");
        }
    }
}

int menu()
{
    do
    {
        Console.WriteLine("\n\nDeseja sair do programa?");
        Console.WriteLine("1 - Sair");
        Console.WriteLine("2 - Continuar");
        option = int.Parse(Console.ReadLine());
    } while (option < 1 || option > 2);

    return option;
}


do
{
    Console.Clear();
    Console.WriteLine("  __  __         _          _                \r\n |  \\/  |       | |        (_)               \r\n | \\  / |  __ _ | |_  _ __  _  ____ ___  ___ \r\n | |\\/| | / _` || __|| '__|| ||_  // _ \\/ __|\r\n | |  | || (_| || |_ | |   | | / /|  __/\\__ \\\r\n |_|  |_| \\__,_| \\__||_|   |_|/___|\\___||___/\r\n                                             ");

    matriz1 = CriarMatriz(qtdLinhas, qtdColunas);
    matriz2 = CriarMatriz(qtdLinhas, qtdColunas);

    GerarValores(matriz1, 0, 10, qtdLinhas, qtdColunas);
    GerarValores(matriz2, 0, 10, qtdLinhas, qtdColunas);

    ImprimirMatriz(matriz1, "Matriz 1", qtdLinhas, qtdColunas);
    ImprimirMatriz(matriz2, "Matriz 2", qtdLinhas, qtdColunas);

    operacao = MenuOperacao();

    resultado = CalcularMatriz(matriz1, matriz2, operacao, qtdLinhas, qtdColunas);

    string msg = "";
    switch(operacao)
    {
        case 1:
            msg = "Soma das matrizes";
            break;
        case 2:
            msg = "Subtração das matrizes";
            break;
        case 3:
            msg = "Multiplicação das matrizes";
            break;
        case 4:
            msg = "Divisão das matrizes";
            break;

    }

    ImprimirMatriz(resultado, msg, qtdLinhas, qtdColunas);
    
} while (menu() == 2);