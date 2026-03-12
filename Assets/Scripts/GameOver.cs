using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] GameManager _gameManager; // Reference to the GameManager script to call the GameOver method
    //GAME OVER
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Handle collision with obstacles or ground here (e.g., end the game, reset the player, etc.)
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Player collided with: " + collision.gameObject.name); // Log the name of the object the player collided with
            _gameManager.GameOver(); // Call the GameOver method on the GameManager script to handle game over logic
        }
    }
}
