using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    //GAME OVER
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Handle collision with obstacles or ground here (e.g., end the game, reset the player, etc.)
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Player collided with: " + collision.gameObject.name); // Log the name of the object the player collided with
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Reload the current scene to reset the game
        }
    }
}
