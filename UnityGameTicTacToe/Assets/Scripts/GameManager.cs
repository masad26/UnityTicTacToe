//This script manages the game's flow and logic.

using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int boardSize = 3;  // Default board size is 3x3.

    private int currentPlayer;  // 1 for Player 1 (X), 2 for Player 2 (O)
    private int[,] gameBoard;   // 2D array to represent the game board

    void Start()
    {
        InitializeBoard();
    }

    // Initialize the game board with empty cells.
    private void InitializeBoard()
    {
        gameBoard = new int[boardSize, boardSize];
        currentPlayer = 1;  // Start with Player 1 (X)
    }

    // Function to make a move on the game board.
    public void MakeMove(int row, int col)
    {
        if (gameBoard[row, col] == 0)
        {
            gameBoard[row, col] = currentPlayer;
            currentPlayer = (currentPlayer == 1) ? 2 : 1;  // Switch players
        }
    }

    // Function to check for a win condition.
    public bool CheckWin(int player)
    {
        // Implement win condition logic here.
        // Check rows, columns, and diagonals for matching symbols (player).
        return false;  // Placeholder return statement.
    }

    // Function to check for a draw condition.
    public bool CheckDraw()
    {
        // Implement draw condition logic here.
        // Check if all cells are filled.
        return false;  // Placeholder return statement.
    }

    // Function to reset the game.
    public void ResetGame()
    {
        InitializeBoard();
    }

    // Function to get the current player.
    public int GetCurrentPlayer()
    {
        return currentPlayer;
    }

    // Function to get the content of a specific cell on the game board.
    public int GetCellContent(int row, int col)
    {
        return gameBoard[row, col];
    }
}
