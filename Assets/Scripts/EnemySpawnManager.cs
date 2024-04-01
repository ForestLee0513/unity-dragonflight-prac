using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    int spawnRange = 2;
    public int maxEnemyCount;
    public GameObject enemyPrefab;
    public bool spawnEnabled;
    public List<GameObject> enemies = new List<GameObject>();
    private static EnemySpawnManager instance;
    public static EnemySpawnManager Instance 
    { 
        get 
        {
            return instance;
        }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {    
        InvokeRepeating("SpawnEnemy", 2f, 5f);   
    }

    void SpawnEnemy()
    {
        if (spawnEnabled)
        {
            int enemyCount = Random.Range(1, maxEnemyCount);
            enemies = enemies.Where((enemy) => enemy != null).ToList();
            for (int i = 0; i < enemyCount; i++)
            {
                GameObject newEnemyGameObject = Instantiate(enemyPrefab, new Vector2(Random.Range(-spawnRange, spawnRange + 1), transform.position.y), Quaternion.identity);
                enemies.Add(newEnemyGameObject);
            }
        }
    }
}
