﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSheet : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player;
    public GameObject projectile;
    public GameObject healthBar;

    Vector3 direction;

    public float projectileForce;

    public float health;
    public float maxHealth;


    public float minDamage;
    public float maxDamage;



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            WrenchNoise.playSound();
            //Debug.Log("Q was pressed.");
            //GameObject spell = Instantiate(projectile, transform.position, Quaternion.identity);
           // Vector3 direction;
            switch (player.GetComponent<PlayerMovement>().lookDirection)
            {
                case PlayerMovement.facing.up:
                    direction = new Vector3(0.0f, 1.0f, 0.0f);
                    break;
                case PlayerMovement.facing.down:
                    direction = new Vector3(0.0f, -1.0f, 0.0f);
                    break;
                case PlayerMovement.facing.left:
                    direction = new Vector3(-1.0f, 0.0f, 0.0f);
                    break;
                case PlayerMovement.facing.right:
                    direction = new Vector3(1.0f, 0.0f, 0.0f);
                    break;
                case PlayerMovement.facing.upright:
                    direction = new Vector3(1.0f, 1.0f, 0.0f);
                    break;
                case PlayerMovement.facing.upleft:
                    direction = new Vector3(-1.0f, 1.0f, 0.0f);
                    break;
                case PlayerMovement.facing.downright:
                    direction = new Vector3(1.0f, -1.0f, 0.0f);
                    break;
                case PlayerMovement.facing.downleft:
                    direction = new Vector3(-1.0f, -1.0f, 0.0f);
                    break;
            }
            direction = direction.normalized;

            GameObject spell = Instantiate(projectile, transform.position + (direction * (1.1f)) , Quaternion.identity);

            //direction = direction.normalized;

            spell.GetComponent<Rigidbody2D>().velocity = direction * projectileForce;


        }
    }




    // Update is called once per frame
   
        public void OnCollisionEnter2D(Collision2D collision)
        {
            //Debug.Log("Collision Detected!");
            if (collision.otherCollider.tag == "Player")
            {
                if (collision.otherCollider.name == "Player1")
                {
                    collision.otherCollider.GetComponent<PlayerSheet>().takeDamage(Random.Range(minDamage, maxDamage));
                }
                else if (collision.otherCollider.name == "Player2")
                {
                    collision.otherCollider.GetComponent<PlayerSheet2>().takeDamage(Random.Range(minDamage, maxDamage));
                }
            }
        }





    public void takeDamage(float damage)
    {
        health = health - Random.Range(minDamage, maxDamage);
        if (health <= 0)
        {
            DeathNoise.playSound();
            //healthBar.GetComponent<FillHealthBar>().slider.value = 0;
            Destroy(player);
        }
    }


}
