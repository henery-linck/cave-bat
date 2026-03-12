using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    #region Serialized Fields
    [SerializeField] private float _flapForce; // Force applied to the player when flapping
    [SerializeField] private InputActionAsset _inputActions; // Reference to the input action asset
    [SerializeField] private InputActionReference _flapAction; // Reference to the input action for flapping
    #endregion

    #region Private Fields
    private Rigidbody2D _rigidBody; // Reference to the player's Rigidbody2D component
    #endregion

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>(); // Get the Rigidbody2D component attached to the player
    }

    // Update is called once per frame
    private void Update()
    {
        if (_flapAction.action.WasPressedThisFrame()) // Check if the flap action was pressed in the current frame
        {
            Flap(); // Call the Flap method to apply the flap force
        }
    }

    private void Flap()
    {
        _rigidBody.AddForce(Vector2.up * _flapForce, ForceMode2D.Impulse); // Apply an upward force to the player using impulse mode
    }
}
