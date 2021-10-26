using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPadSFX : MonoBehaviour
{
    public AudioSource playSound;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponentInParent<PlayerCharacterController>() != null) {
            playSound.Play();
        }
    }
}
