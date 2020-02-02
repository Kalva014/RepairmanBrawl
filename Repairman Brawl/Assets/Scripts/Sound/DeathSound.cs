using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathSound : MonoBehaviour
{
    // Start is called before the first frame update
    public static AudioClip throwsound;

    static AudioSource throwsrc;
    //static AudioSource deathsrc;
    void Start()
    {

        //throwsound = Resources.Load<AudioClip>("throw");
        //deathsound = Resources.Load<AudioClip>("death");

        throwsrc = GetComponent<AudioSource>();
        //deathsrc = GetComponent<AudioSource>();
        //throwsrc.Play();
    }

    // Update is called once per frame
    void Update()
    {
        //playSound("throw");
        //throwsrc.Play();
    }

    public static void playSound()
    {

        throwsrc.Play();

    }




}