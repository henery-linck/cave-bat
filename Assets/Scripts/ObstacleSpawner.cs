using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _obstaclePrefab; // Prefab of the obstacle to spawn
    [SerializeField] private float _spawnInterval; // Time interval between spawns
    [SerializeField] private float _minY, maxY; // Minimum and maximum Y positions for spawning obstacles

    private float _spawnTimer; // Timer to keep track of time since the last spawn

    // Update is called once per frame
    void Update()
    {
        _spawnTimer += Time.deltaTime; // Increment the spawn timer by the time elapsed since the last frame.

        if (_spawnTimer >= _spawnInterval) // Check if the spawn timer has reached or exceeded the spawn interval
        {
            SpawnObstacle(); // Spawn a new obstacle
            _spawnTimer = 0f; // Reset the spawn timer
        }
    }

    private void SpawnObstacle()
    {
        Instantiate(_obstaclePrefab, new Vector3(transform.position.x, Random.Range(_minY, maxY), 0), Quaternion.identity); // Instantiate a new obstacle at the spawner's X position and a random Y position within the specified range
    }
}
