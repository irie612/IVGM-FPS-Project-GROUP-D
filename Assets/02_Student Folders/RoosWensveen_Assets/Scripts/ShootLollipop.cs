using UnityEngine;
using System.Collections;

public class ShootLollipop : MonoBehaviour {

    AudioSource audioSource;
    public AudioClip clip;

    public void OnMouseDown()
    {
        AudioSource.PlayClipAtPoint(clip, new Vector3(5, 1, 2));
        Destroy(gameObject, 0.117f);
    }
}
