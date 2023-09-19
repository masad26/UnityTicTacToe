using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int currentPlayer;   // 1 for Player 1 (X), 2 for Player 2 (O)
    public int boardSize;       // Size of the board (e.g., 3 for 3x3)
    private int[,] gameBoard;    // 2D array to represent the game board
    private bool isGameOver;    // Flag to track game over state

    void Start()
    {
        // Initialize variables, set board size, create an empty game board, and start with Player 1.
        boardSize = 3;  // Set your desired board size here.
        gameBoard = new int[boardSize, boardSize];
        currentPlayer = 1;
        isGameOver = false;
    }

    // Function to handle player's move.
    public void MakeMove(int row, int col)
    {
        // Check if the cell is empty and the game is not over.
        if (gameBoard[row, col] == 0 && !isGameOver)
        {
            // Set the cell with the current player's symbol (1 for X, 2 for O).
            gameBoard[row, col] = currentPlayer;

            // Check for a win.
            if (CheckWin())
            {
                Debug.Log("Player " + currentPlayer + " wins!");
                isGameOver = true;
            }
            // Check for a draw (all cells are filled).
            else if (CheckDraw())
            {
                Debug.Log("It's a draw!");
                isGameOver = true;
            }
            else
            {
                // Switch to the other player.
                currentPlayer = (currentPlayer == 1) ? 2 : 1;
            }
        }
    }

    // Function to check for a win.
    private bool CheckWin()
    {
        // Check rows for a win.
        for (int row = 0; row < boardSize; row++)
        {
            if (gameBoard[row, 0] != 0 && gameBoard[row, 0] == gameBoard[row, 1] && gameBoard[row, 0] == gameBoard[row, 2])
            {
                return true;
            }
        }

        // Check columns for a win.
        for (int col = 0; col < boardSize; col++)
        {
            if (gameBoard[0, col] != 0 && gameBoard[0, col] == gameBoard[1, col] && gameBoard[0, col] == gameBoard[2, col])
            {
                return true;
            }
        }

        // Check diagonals for a win.
        if (gameBoard[0, 0] != 0 && gameBoard[0, 0] == gameBoard[1, 1] && gameBoard[0, 0] == gameBoard[2, 2])
        {
            return true;
        }

        if (gameBoard[0, 2] != 0 && gameBoard[0, 2] == gameBoard[1, 1] && gameBoard[0, 2] == gameBoard[2, 0])
        {
            return true;
        }

        return false;  // No win conditions met.
    }

    // Function to check for a draw.
    private bool CheckDraw()
    {
        for (int row = 0; row < boardSize; row++)
        {
            for (int col = 0; col < boardSize; col++)
            {
                if (gameBoard[row, col] == 0)
                {
                    return false;  // There is an empty cell, so it's not a draw yet.
                }
            }
        }

        return true;  // All cells are filled, and no win condition is met.
    }
}
