using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrencyPickup : MonoBehaviour
{

    public int value;
    public enum typeCurrency { gem, coin};
    public typeCurrency currencyType;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Player")
        {
            PlayerStats.playerStats.AddCurrency(this);
            Destroy(gameObject);
        }
        //Destroy(gameObject);
    }
}
