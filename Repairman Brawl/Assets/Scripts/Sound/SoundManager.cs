using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
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
    }

    // Update is called once per frame
    void Update()
    {
        //playSound("throw");
    }

    public static void playSound (string clip)
    {
        
                throwsrc.Play();
            
    }




}
