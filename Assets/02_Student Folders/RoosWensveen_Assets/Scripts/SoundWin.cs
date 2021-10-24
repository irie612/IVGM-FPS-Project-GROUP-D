using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundWin : MonoBehaviour
{
    AudioSource audioSource;
    bool play;
    bool playOnce = true;

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
        play = true;
    }

    public void Update()
    {
        if (play == true && playOnce == true)
        {
            if(GameObject.FindGameObjectsWithTag("Lollipop").Length <= 0) 
            {
                if(GameObject.FindGameObjectsWithTag("Enemy").Length <= 0) 
                {
                    audioSource.Play();
                    playOnce = false; 
                }
            }
        }

        if (play == false && playOnce == true)
        {
            audioSource.Stop();
            playOnce = false;
        }
    }
}
