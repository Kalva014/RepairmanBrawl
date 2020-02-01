using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSheet : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player;

    public float health;
    public float maxHealth;


    public float minDamage;
    public float maxDamage;



    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision Detected!");
        if (collision.otherCollider.tag == "Player")
        {
            collision.otherCollider.GetComponent<PlayerSheet>().takeDamage(Random.Range(minDamage, maxDamage));
        }
    }





    void takeDamage(float damage)
    {
        health = health - Random.Range(minDamage, maxDamage);
        if (health <= 0)
        {
            Destroy(player);
        }
    }
}
