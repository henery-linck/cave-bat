using UnityEngine;

public class ParallaxLoop : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        var renderer = GetComponent<SpriteRenderer>(); // Get the SpriteRenderer component to determine the width of the layer
        if (transform.position.x <= -renderer.bounds.size.x) // Check if the layer has moved past the left edge
        {
            transform.position += new Vector3(renderer.bounds.size.x * 2, 0, 0); // Move the layer to the right to create a looping effect
        }
    }
}
