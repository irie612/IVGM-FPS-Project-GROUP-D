using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundDialog : MonoBehaviour
{
    AudioSource audioSource;
    bool play;
    bool playOnce = true;

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
        play = true;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (play == true && playOnce == true)
        {
            if (other.gameObject.tag == "Player") 
            {
                audioSource.Play();
                playOnce = false; 
            }
        }

        if (play == false && playOnce == true)
        {
            audioSource.Stop();
            playOnce = false;
        }
    }
}
