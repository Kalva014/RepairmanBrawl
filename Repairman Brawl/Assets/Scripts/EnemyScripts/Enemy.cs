using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health;
    public float maxHealth;

    public GameObject healthbar;
    public UnityEngine.UI.Slider healthbarSlider;
    public GameObject lootdrop;

    void Start()
    {
        health = maxHealth;
    }

    public void DealDamage(float damage)
    {
        healthbar.SetActive(true);
        
        health = health - damage;
        CheckDeath();
        healthbarSlider.value = calculateHealthPercentage();
    }

    public void HealCharacter(float heal)
    {
        health = health + heal;
        CheckOverheal();
        healthbarSlider.value = calculateHealthPercentage();
    }
    private void CheckOverheal()
    {
        if(health < maxHealth)
        {
            health = maxHealth;
        }
    }

    public void CheckDeath()
    {
        if (health <= 0)
        {
            Destroy(gameObject); // kills sprite
            Instantiate(lootdrop,transform.position,Quaternion.identity);
        }
    }

    private float calculateHealthPercentage()
    {
        return (health / maxHealth);
    }
}
