using UnityEngine;

public class PrefabSpawner : MonoBehaviour
{
    [Header("Prefab Settings")]
    public GameObject[] prefabsToSpawn; // List of prefabs

    [Header("Spawn Position")]
    public float fixedY = 0f;
    public float minX = -5f;
    public float maxX = 5f;
    public float minZ = -5f;
    public float maxZ = 5f;

    [Header("Spawn Timing")]
    public float spawnInterval = 1f;

    private float spawnTimer;

    void Update()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= spawnInterval)
        {
            SpawnPrefab();
            spawnTimer = 0f;
        }
    }

    void SpawnPrefab()
    {
        if (prefabsToSpawn == null || prefabsToSpawn.Length == 0)
        {
            Debug.LogWarning("No prefabs assigned to spawn.");
            return;
        }

        // Pick a random prefab from the list
        GameObject prefab = prefabsToSpawn[Random.Range(0, prefabsToSpawn.Length)];

        // Random spawn position
        float randomX = Random.Range(minX, maxX);
        float randomZ = Random.Range(minZ, maxZ);
        Vector3 spawnPosition = new Vector3(randomX, fixedY, randomZ);

        // Instantiate the prefab without changing its color
        Instantiate(prefab, spawnPosition, Quaternion.identity);
    }
}