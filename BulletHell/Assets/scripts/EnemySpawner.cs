using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [Header("Enemigos normales")]
    public GameObject[] enemyPrefabs;
    public float spawnInterval = 2f;
    public float spawnXMin = -2.4f;
    public float spawnXMax = 2.4f;
    public float spawnY = 6f;
    public int maxEnemies = 5;

    [Header("Jefe")]
    public GameObject bossPrefab;
    public float bossSpawnTime = 30f;
    private bool bossSpawned = false;
    private float elapsedTime = 0f;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1f, spawnInterval);
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (!bossSpawned && elapsedTime >= bossSpawnTime)
        {
            SpawnBoss();
            bossSpawned = true;

            // Opcional: dejar de spawnear enemigos normales
            CancelInvoke("SpawnEnemy");
        }
    }

    void SpawnEnemy()
    {
        int currentEnemies = GameObject.FindGameObjectsWithTag("Enemy").Length;
        if (currentEnemies >= maxEnemies) return;

        float randomX = Random.Range(spawnXMin, spawnXMax);
        Vector2 spawnPos = new Vector2(randomX, spawnY);

        // Elegir prefab aleatorio
        int index = Random.Range(0, enemyPrefabs.Length);
        Instantiate(enemyPrefabs[index], spawnPos, Quaternion.identity);
    }


    void SpawnBoss()
    {
        Vector2 spawnPos = new Vector2(0f, 6f); // centro arriba
        Instantiate(bossPrefab, spawnPos, Quaternion.identity);

    }
}