using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

    public static AudioClip cheeseSound, potionSound;
    public static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        cheeseSound = Resources.Load<AudioClip>("Cheese");
        potionSound = Resources.Load<AudioClip>("Potion");
        audioSrc = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip){
        switch(clip) {
            case "Cheese":
                audioSrc.PlayOneShot(cheeseSound);
                break;
            case "Potion":
                audioSrc.PlayOneShot(potionSound);
                break;
        }
    }

    
}
