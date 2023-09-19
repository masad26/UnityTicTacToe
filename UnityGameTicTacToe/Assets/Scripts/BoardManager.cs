//This script manages the game board's
//visual representation and user interactions.

using UnityEngine;
using UnityEngine.UI;

public class BoardManager : MonoBehaviour
{
    public GameManager gameManager;  // Reference to the GameManager script.
    public Text gameOverText;        // Text to display game over messages.
    public Button restartButton;     // Button to restart the game.
    public GameObject cellPrefab;    // Reference to the cell prefab.
    public Transform boardParent;    // Parent object to hold the cells.

    private GameObject[,] cells;     // 2D array to hold references to the cell GameObjects.

    void Start()
    {
        InitializeBoard();
        restartButton.onClick.AddListener(RestartGame);
    }

    // Initialize the game board with cells.
    private void InitializeBoard()
    {
        cells = new GameObject[gameManager.boardSize, gameManager.boardSize];

        for (int row = 0; row < gameManager.boardSize; row++)
        {
            for (int col = 0; col < gameManager.boardSize; col++)
            {
                GameObject cell = Instantiate(cellPrefab, boardParent);
                cell.transform.position = new Vector3(col, -row, 0);

                int currentRow = row;
                int currentCol = col;
                cell.GetComponent<Button>().onClick.AddListener(() => OnCellClick(currentRow, currentCol));

                cells[row, col] = cell;
            }
        }
    }

    // Handle user's input and update the game.
    public void OnCellClick(int row, int col)
    {
        if (!gameManager.CheckWin(1) && !gameManager.CheckWin(2) && !gameManager.CheckDraw())
        {
            gameManager.MakeMove(row, col);
            UpdateCellText(row, col);
            UpdateGameOverState();
        }
    }

    // Update the visual representation of the game board.
    private void UpdateCellText(int row, int col)
    {
        Text cellText = cells[row, col].GetComponentInChildren<Text>();
        int currentPlayer = gameManager.GetCellContent(row, col);
        cellText.text = (currentPlayer == 1) ? "X" : "O";
    }

    // Show game over message and handle game reset.
    private void UpdateGameOverState()
    {
        if (gameManager.CheckWin(1))
        {
            ShowGameOverMessage("Player 1 (X) wins!");
        }
        else if (gameManager.CheckWin(2))
        {
            ShowGameOverMessage("Player 2 (O) wins!");
        }
        else if (gameManager.CheckDraw())
        {
            ShowGameOverMessage("It's a draw!");
        }
    }

    // Display game over message.
    private void ShowGameOverMessage(string message)
    {
        gameOverText.text = message;
    }

    // Restart the game.
    private void RestartGame()
    {
        gameManager.ResetGame();
        gameOverText.text = "";
        foreach (GameObject cell in cells)
        {
            cell.GetComponentInChildren<Text>().text = "";
        }
    }
}
