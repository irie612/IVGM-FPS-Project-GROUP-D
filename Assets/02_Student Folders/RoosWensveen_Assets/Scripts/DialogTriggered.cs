using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTriggered : MonoBehaviour
{

    public DialogText dt;
    public DialogText dialogtext;

    void OnTriggerEnter (Collider other) {
        if (other.gameObject.tag == "Player") {
            dialogtext.O();
        }
    }
}
