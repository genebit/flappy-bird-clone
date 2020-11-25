using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnClouds : MonoBehaviour
{
    public GameObject cloudPrefab;
    void Start()
    {
        StartCoroutine(SpawnWave());
    }
    void SpawnCloud() {
        Vector2 spawnPosition = new Vector2(6.8f, Random.Range(3f, 2.5f));
        GameObject clone = Instantiate(cloudPrefab, spawnPosition, Quaternion.identity);
        clone.transform.parent = GameObject.Find("Clouds Spawner").transform;
    }
    IEnumerator SpawnWave() {
        while (true) {
            yield return new WaitForSeconds(14f);
            SpawnCloud();
        }
    }
}
