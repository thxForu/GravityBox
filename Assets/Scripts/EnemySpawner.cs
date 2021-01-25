using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private int timeForSpawn;

    private void Start()
    {
        StartCoroutine(SpawnEnemy());
        Instantiate(enemy, spawnPoints[0].position, spawnPoints[0].rotation);
    }

    private IEnumerator SpawnEnemy()
    {
        while (true)
        {
            var randomNumb = Random.Range(0, spawnPoints.Length);
            Instantiate(enemy, spawnPoints[randomNumb].position, spawnPoints[randomNumb].rotation);
            yield return new WaitForSeconds(Mathf.Clamp(Random.Range(3, timeForSpawn),3, timeForSpawn));
        }
    }
}
