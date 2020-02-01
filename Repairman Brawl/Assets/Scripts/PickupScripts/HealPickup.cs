using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealPickup : MonoBehaviour
{
    public float heal;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Player")
        {
            //Debug.Log(heal);
            PlayerStats.playerStats.HealCharacter(heal);
            Destroy(gameObject);
        }
    }
}
