using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private float _flapForce; // Force applied to the player when flapping
    [SerializeField] private Rigidbody2D _rigidBody; // Reference to the player's Rigidbody2D component
    [SerializeField] private InputActionAsset _inputActions; // Reference to the Input Action Asset

    // Update is called once per frame
    void Update()
    {
    }
}
