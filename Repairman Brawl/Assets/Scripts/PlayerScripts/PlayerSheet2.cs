using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSheet2 : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.Comma))
        {
            //Debug.Log("Q was pressed.");
            //GameObject spell = Instantiate(projectile, transform.position, Quaternion.identity);
            // Vector3 direction;
            switch (player.GetComponent<Player2Movement>().lookDirection)
            {
                case Player2Movement.facing.up:
                    direction = new Vector3(0.0f, 1.0f, 0.0f);
                    break;
                case Player2Movement.facing.down:
                    direction = new Vector3(0.0f, -1.0f, 0.0f);
                    break;
                case Player2Movement.facing.left:
                    direction = new Vector3(-1.0f, 0.0f, 0.0f);
                    break;
                case Player2Movement.facing.right:
                    direction = new Vector3(1.0f, 0.0f, 0.0f);
                    break;
                case Player2Movement.facing.upright:
                    direction = new Vector3(1.0f, 1.0f, 0.0f);
                    break;
                case Player2Movement.facing.upleft:
                    direction = new Vector3(-1.0f, 1.0f, 0.0f);
                    break;
                case Player2Movement.facing.downright:
                    direction = new Vector3(1.0f, -1.0f, 0.0f);
                    break;
                case Player2Movement.facing.downleft:
                    direction = new Vector3(-1.0f, -1.0f, 0.0f);
                    break;
            }

            direction = direction.normalized;
            GameObject spell = Instantiate(projectile, transform.position + (direction * (1.1f)), Quaternion.identity);


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
            //healthBar.GetComponent<FillHealthBar2>().slider.value = 0;
            Destroy(player);
        }
    }


}
