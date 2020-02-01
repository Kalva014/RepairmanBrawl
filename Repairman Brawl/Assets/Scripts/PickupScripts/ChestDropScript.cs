using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestDropScript : MonoBehaviour
{
    public GameObject[] loot;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Player" || collision.tag == "PlayerProjectile")
        {
            int x = Random.Range(0, 3); //minimum number is inclusive and maximum number is exclusive. So [0,3)
            //Debug.Log(x);
            Instantiate(loot[x], transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
