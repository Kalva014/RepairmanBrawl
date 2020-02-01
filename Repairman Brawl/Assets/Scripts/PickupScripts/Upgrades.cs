using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrades : MonoBehaviour
{
    public int healthInc;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Player")
        {
            //increase projectile shot;
            PlayerStats.playerStats.maxHealth += healthInc;
            PlayerStats.playerStats.health += healthInc;
            PlayerStats.playerStats.SetHealthText();
            Destroy(gameObject);
        }
    }
}
