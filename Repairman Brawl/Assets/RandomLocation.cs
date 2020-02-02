using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLocation : MonoBehaviour
{

    public GameObject Obstacle;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-1f,1f), Random.Range(-1f, 1f), 1);
        transform.position = transform.position + spawnPosition;
        Debug.Log(transform.position);
    }
}
