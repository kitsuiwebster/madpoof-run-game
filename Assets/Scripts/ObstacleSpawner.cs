using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnInterval = 2.0f;
    private float timer = 0.0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            float spawnXPosition = Random.Range(0, 3) switch
            {
                0 => -2f,
                1 => 0f,
                2 => 2f,
                _ => 0f
            };

            Vector3 spawnPosition = new Vector3(spawnXPosition, 0.5f, transform.position.z + 20);
            Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
            timer = 0.0f;
        }
    }
}
