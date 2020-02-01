using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject collide;
    public float minDamage;
    public float maxDamage;



    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            collision.GetComponent<Attack>().TakeDamage(Random.Range(minDamage, maxDamage));
        }
    }

    void TakeDamage(float x)
    {
        GetComponent<PlayerStats>().DealDamage(x);
    }
}
