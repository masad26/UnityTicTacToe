using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text currentPlayerText;   // Text to display the current player's turn.
    public GameObject menuPanel;    // The main menu panel.
    public GameObject gamePanel;    // The in-game panel.
    public Button startButton;       // Button to start the game.
    public Button restartButton;     // Button to restart the game.

    public GameManager gameManager;  // Reference to the GameManager script.

    void Start()
    {
        // Attach button click events to functions.
        startButton.onClick.AddListener(StartGame);
        restartButton.onClick.AddListener(RestartGame);

        // Hide the game panel at the start.
        gamePanel.SetActive(false);
    }

    // Function to start the game.
    private void StartGame()
    {
        menuPanel.SetActive(false);
        gamePanel.SetActive(true);
        gameManager.ResetGame();
        UpdateCurrentPlayerText();
    }

    // Function to restart the game.
    private void RestartGame()
    {
        gameManager.ResetGame();
        UpdateCurrentPlayerText();
        ClearCellText();
    }

    // Function to update the text displaying the current player's turn.
    public void UpdateCurrentPlayerText()
    {
        int currentPlayer = gameManager.GetCurrentPlayer();
        currentPlayerText.text = "Player " + currentPlayer + "'s Turn";
    }

    // Function to clear the text of all cells on the game board.
    private void ClearCellText()
    {
        GameObject[] cells = GameObject.FindGameObjectsWithTag("Cell");
        foreach (GameObject cell in cells)
        {
            Text cellText = cell.GetComponentInChildren<Text>();
            cellText.text = "";
        }
    }
}