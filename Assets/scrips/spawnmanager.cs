using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class spawnmanager : MonoBehaviour
{
    public GameObject enemyPrefab;
   

    private float spawnPositionRangez = 200f;
    private float spawnPositionRangez2 = 600f;
    private float spawnPositionRangex = -200f;
    private float spawnPositionRangex2 = 500f;

    private int enemiesPerWave = 5;
    private int enemiesLeft;

    void Start()
    {
        SpawnEnemyWave(enemiesPerWave);
    }

    private void Update()
    {
 enemiesLeft = FindObjectsOfType<enemy>().Length;
        if (enemiesLeft <= 0)
        {
            enemiesPerWave++;
            SpawnEnemyWave(enemiesPerWave);
        }
    }

    private Vector3 RandomSpawnPostion()
    {
        float xRandom = Random.Range(spawnPositionRangex2,spawnPositionRangex);
        float zRandom = Random.Range(spawnPositionRangez2, spawnPositionRangez);
        

        return new Vector3(xRandom, 1, zRandom);
    }

    private void SpawnEnemy()
    {
        Instantiate(enemyPrefab, RandomSpawnPostion(), enemyPrefab.transform.rotation);
    }

    private void SpawnEnemyWave(int totalEnemies)
    {
        for (int i = 0; i < totalEnemies; i++)
        {
            SpawnEnemy();
        }
    }
}
