using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<GameObject> Enemies = new List<GameObject>();
    public float spawnRate;
    private float x, y;
    private Vector3 spawnPos;

    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy()
    {
        spawnPos.x = 0;
        spawnPos.y = 0;
        x = Random.Range(-1f, 1f);
        y = Random.Range(-1f, 1f);
        spawnPos.x += x;
        spawnPos.y += y;
        Debug.Log(spawnPos);
        Instantiate(Enemies[0], spawnPos, Quaternion.identity);
        yield return new WaitForSeconds(spawnRate);
        StartCoroutine(SpawnEnemy());

    }
}
