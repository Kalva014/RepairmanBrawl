﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endgame : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player1;
    public GameObject player2;



    private void Update()
    {
        if (!player1 || !player2)
        {
            StartCoroutine(end());
        }
    }


    



    IEnumerator end()
    {
        if(!player1 || !player2)
        {
            //DeathSound.playSound();
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    



}
