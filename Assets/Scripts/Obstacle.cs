using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private float _moveSpeed; // Speed at which the obstacle moves to the left
    [SerializeField] private float _destroyXPosition; // X position at which the obstacle will be destroyed

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * _moveSpeed * Time.deltaTime; // Move the obstacle to the left based on the move speed and delta time

        if (transform.position.x < _destroyXPosition) // Check if the obstacle has moved past the destroy X position
        {
            Destroy(gameObject); // Destroy the obstacle game object
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // Check if the obstacle collided with the player
        {
            collision.GetComponent<Player>().IncrementScore(); // Increment the player's score by calling the IncrementScore method on the Player script
            Debug.Log($"Player passed through: {gameObject.name}. Score: {collision.GetComponent<Player>().Score}."); // Log the name of the obstacle that the player passed through
        }
    }
}
