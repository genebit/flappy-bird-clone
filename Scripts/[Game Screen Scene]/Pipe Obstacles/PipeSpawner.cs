using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    [Range(0, 10)]
    public float spawnTime;
    void Start()
    {
        StartCoroutine(SpawnWave());
    }
    void SpawnCloud() {
        Vector2 spawnPosition = new Vector2(3f, Random.Range(-2.75f, -0f));
        
        GameObject clone = Instantiate(pipePrefab, spawnPosition, Quaternion.identity);
        clone.transform.parent = GameObject.Find("Obstacle Pipes Spawner").transform;
    }
    IEnumerator SpawnWave() {
        while (true) {
            yield return new WaitForSeconds(spawnTime);
            SpawnCloud();
        }
    }
       
}
