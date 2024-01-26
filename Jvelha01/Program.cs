using System;

class Program
{
    static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static int playerTurn = 1; // 1 for Player 1, 2 for Player 2

    static void Main()
    {
        int choice;
        int flag = 0;

        do
        {
            Console.Clear(); // Limpar a tela a cada jogada
            Console.WriteLine("Jogo da Velha - Jogador {0}:", playerTurn);
            Console.WriteLine("\n");

            Board();

            // Verificar se o movimento do jogador é válido
            do
            {
                Console.Write("Por favor, escolha uma posição para marcar: ");
                choice = int.Parse(Console.ReadLine()) - 1;

                if (choice < 0 || choice > 8)
                {
                    Console.WriteLine("Posição inválida! Tente novamente.");
                }
                else if (board[choice] == 'X' || board[choice] == 'O')
                {
                    Console.WriteLine("A posição já está ocupada! Tente novamente.");
                }
                else
                {
                    board[choice] = (playerTurn % 2 == 0) ? 'O' : 'X';
                    playerTurn = (playerTurn % 2 == 0) ? 1 : 2;
                    flag = 1;
                }
            } while (flag == 0);

            flag = 0;
        }
        while (!CheckWin() && !CheckDraw());

        Console.Clear();
        Board();

        if (CheckWin())
        {
            Console.WriteLine("Jogador {0} venceu!", (playerTurn % 2 == 0) ? 1 : 2);
        }
        else
        {
            Console.WriteLine("Empate! O jogo terminou em empate.");
        }

        Console.ReadLine();
    }

    private static void Board()
    {
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", board[0], board[1], board[2]);
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", board[3], board[4], board[5]);
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", board[6], board[7], board[8]);
        Console.WriteLine("     |     |      ");
    }

    private static bool CheckWin()
    {
        // Verificar vitória nas linhas, colunas e diagonais
        for (int i = 0; i < 3; i++)
        {
            if ((board[i * 3] == board[i * 3 + 1] && board[i * 3 + 1] == board[i * 3 + 2]) ||
                (board[i] == board[i + 3] && board[i + 3] == board[i + 6]) ||
                ((i == 0 && board[0] == board[4] && board[4] == board[8]) ||
                 (i == 2 && board[2] == board[4] && board[4] == board[6])))
            {
                return true;
            }
        }
        return false;
    }

    private static bool CheckDraw()
    {
        // Verificar empate (todos os espaços preenchidos)
        for (int i = 0; i < 9; i++)
        {
            if (board[i] != 'X' && board[i] != 'O')
            {
                return false; // Ainda há pelo menos um espaço vazio
            }
        }
        return true; // Todos os espaços estão preenchidos
    }
}
