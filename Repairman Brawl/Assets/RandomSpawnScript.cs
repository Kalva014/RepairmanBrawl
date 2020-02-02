using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnScript : MonoBehaviour
{
    public GameObject Obstacle;
    public float numObstacles;

    // Start is called before the first frame update
    //void Start()
    //{
        //Vector3 spawnPosition = new Vector3(Random.Range(-10f,12f), Random.Range(-4f, 6.5f), 1);
        //transform.position = transform.position + spawnPosition;
        //Debug.Log(transform.position);

    //}

    void Start()
    {
        //GameObject wall = Instantiate(Obstacle, transform.position, Quaternion.identity);

        for (int i = 0; i < numObstacles; ++i)
        {
            GameObject wall = Instantiate(Obstacle, transform.position, Quaternion.identity);
        }
    }
   
}
