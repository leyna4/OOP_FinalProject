using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float spawnRadius = 5f;
    [SerializeField] private int maxEnemies = 5;

    private float timer;
    private int currentEnemyCount;

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnRadius && currentEnemyCount < maxEnemies)
        {
            SpawnEnemy();
            timer = 0f;
        }
    }

    private void SpawnEnemy()
    {
        Vector2 randomPos = (Vector2)transform.position + Random.insideUnitCircle * spawnRadius;
        Instantiate(enemyPrefab, randomPos, Quaternion.identity);
        currentEnemyCount++;
    }

}
