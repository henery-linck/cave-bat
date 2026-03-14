using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameManager _gameManager; // Reference to the GameManager script to call the GameOver method
    [SerializeField] private AudioSource _audioSource; // Reference to the AudioSource component for playing sound effects
    [SerializeField] private AudioClip _collisionSound; // Reference to the AudioClip for the collision sound effect

    //GAME OVER
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Handle collision with obstacles or ground here (e.g., end the game, reset the player, etc.)
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            _audioSource.pitch = 1f;
            _audioSource.volume = 0.9f;
            _audioSource.PlayOneShot(_collisionSound); // Play the collision sound effect using the AudioSource component
            _gameManager.GameOver(); // Call the GameOver method on the GameManager script to handle game over logic
        }
    }
}
