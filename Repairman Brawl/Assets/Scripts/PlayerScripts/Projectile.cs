using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    //public GameObject projectile = this;
    public float minDamage;
    public float maxDamage;

   
    public void OnCollisionEnter2D(Collision2D collision)
    {
       

        if (collision.otherCollider.name == "Player1")
        {
            collision.otherCollider.GetComponent<PlayerSheet2>().takeDamage(Random.Range(minDamage, maxDamage));
            Destroy(gameObject);
        }
        else if (collision.otherCollider.name == "Player2")
        {
            collision.otherCollider.GetComponent<PlayerSheet>().takeDamage(Random.Range(minDamage, maxDamage));
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }
}
