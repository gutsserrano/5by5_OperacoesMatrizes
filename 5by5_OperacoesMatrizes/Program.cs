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

void GerarValores(float[,] matriz, int min, int max)
{
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdColunas; coluna++)
        {
            matriz[linha, coluna] = new Random().Next(min, max);
        }
    }
}

void ImprimirMatriz(float[,] matriz, string titulo)
{
    Console.Write("\n\n"+titulo);
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        Console.WriteLine();
        for (int coluna = 0; coluna < qtdColunas; coluna++)
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

    matriz1 = CriarMatriz(qtdLinhas, qtdColunas);
    matriz2 = CriarMatriz(qtdLinhas, qtdColunas);
    resultado = CriarMatriz(qtdLinhas, qtdColunas);

    GerarValores(matriz1, 0, 10);
    GerarValores(matriz2, 0, 10);

    ImprimirMatriz(matriz1, "Matriz 1");
    ImprimirMatriz(matriz2, "Matriz 2");

    operacao = MenuOperacao();

    // Operando as matrizes
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdColunas; coluna++)
        {
            switch (operacao)
            {
                // Soma
                case 1:
                    resultado[linha, coluna] = matriz1[linha, coluna] + matriz2[linha, coluna];
                    break;

                // Subtração
                case 2:
                    resultado[linha, coluna] = matriz1[linha, coluna] - matriz2[linha, coluna];
                    break;

                // Multiplicação
                case 3:
                    resultado[linha, coluna] = matriz1[linha, coluna] * matriz2[linha, coluna];
                    break;

                // Divisão
                case 4:
                    if (matriz2[linha, coluna] != 0)
                        resultado[linha, coluna] = matriz1[linha, coluna] / matriz2[linha, coluna];
                    else
                        resultado[linha, coluna] = float.NaN;
                    break;
                default:
                    resultado[linha, coluna] = float.NaN;
                    break;
            }
        }
    }

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

    ImprimirMatriz(resultado, msg);
    
} while (menu() == 2);