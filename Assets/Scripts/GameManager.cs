using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject _menuPanel; // Reference to the menu panel GameObject
    [SerializeField] GameObject _gameUIPanel; // Reference to the game UI panel GameObject
    [SerializeField] GameObject _gameOverPanel; // Reference to the game over panel GameObject

    public static bool SkipMenu { get; set; } = false; // Static property to determine whether to skip the menu

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (SkipMenu)
        {
            SkipMenu = false; // Reset SkipMenu to false for the next time the game starts
            StartGame(); // If SkipMenu is true, start the game immediately
            return;
        }

        Time.timeScale = 0; // Pause the game by setting time scale to 0
        _menuPanel.SetActive(true); // Show the menu panel
        _gameUIPanel.SetActive(false); // Hide the score panel
        _gameOverPanel.SetActive(false); // Hide the game over panel
    }

    public void StartGame()
    {
        _menuPanel.SetActive(false); // Hide the menu panel
        _gameUIPanel.SetActive(true); // Show the score panel

        Time.timeScale = 1f; // Resume the game by setting time scale to 1
    }

    public void GameOver()
    {
        _gameOverPanel.SetActive(true); // Show the game over panel
        Time.timeScale = 0; // Pause the game by setting time scale to 0
    }

    public void RestartGame()
    {
        Time.timeScale = 1f; // Resume the game by setting time scale to 1
        SkipMenu = true; // Set SkipMenu to true to skip the menu when restarting the game
        UnityEngine.SceneManagement.SceneManager.LoadScene(0); // Reload the first scene (index 0) to restart the game
    }
}
