using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillHealthBar : MonoBehaviour
{
    public GameObject player;
    public Image fillImage;
    private Slider slider;
    float playerHealth;
    float playerMaxHealth;
    float fillValue;

    // Start is called before the first frame update
    void Start()
    {
        //player = gameObject;
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        playerHealth = player.GetComponent<PlayerSheet>().health;
        playerMaxHealth = player.GetComponent<PlayerSheet>().maxHealth;
        fillValue = playerHealth / playerMaxHealth;
        slider.value = fillValue;
    }
}
