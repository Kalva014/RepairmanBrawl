using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{

    public static PlayerStats playerStats;

    public GameObject player;

    public float health;
    public Text healthText;
    public Slider healthSlider;
    public float maxHealth;
    public Text numCoins;
    public int coin;
    public Text numGems;
    public int gem;

    void Awake()
    {
        if(playerStats != null)
        {
            Destroy(playerStats);
        }
        else
        {
            playerStats = this;
        }
        DontDestroyOnLoad(this);
    }
    void Start()
    {
        health = maxHealth;
        healthSlider.value = 1;
        SetHealthText();
    }

    public void DealDamage(float damage)
    {
        health = health - damage;
        CheckDeath();
        SetHealthSlider();
        SetHealthText();

    }

    public void HealCharacter(float heal)
    {
        health = health + heal;
        CheckOverheal();
        SetHealthSlider();
        SetHealthText();
    }

    private void CheckOverheal()
    {
        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }

    public void CheckDeath()
    {
        if (health <= 0)
        {
            Destroy(player); // kills sprite
        }
    }

    public void SetHealthSlider()
    {
        healthSlider.value = (health / maxHealth);
    }

    public void SetHealthText()
    {
        if (health < 0)
        {
            health = 0;
        }
        healthText.text = Mathf.Ceil(health).ToString() + "/" + Mathf.Ceil(maxHealth).ToString(); //Mathf.Ceil() rounds up numder
    }

    public void AddCurrency(CurrencyPickup currency)
    {
        if (currency.currencyType == CurrencyPickup.typeCurrency.coin)
        {
            PlayerStats.playerStats.coin += currency.value;
            numCoins.text = "Coins: " + coin.ToString();
            //Debug.Log(PlayerStats.playerStats.coin);
        }
        else if (currency.currencyType == CurrencyPickup.typeCurrency.gem)
        {
            PlayerStats.playerStats.gem += currency.value;
            numGems.text = "Gems: " + gem.ToString();
            //Debug.Log(PlayerStats.playerStats.gem);
        }
       
    }
   
}
