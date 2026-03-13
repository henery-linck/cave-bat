using UnityEngine;

public class ParallaxLayer : MonoBehaviour
{
    [SerializeField] private float _parallaxFactor; // Factor to control the parallax effect (0.5 means it moves at half the speed of the camera)

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * _parallaxFactor * Time.deltaTime; // Move the layer to the left based on the parallax factor and time
    }
}
