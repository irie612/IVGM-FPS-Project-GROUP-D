using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTriggered : MonoBehaviour
{

    public DialogText dt;
    public DialogText dialogtext;
    bool visited = false;

    void OnTriggerEnter (Collider other) {
        if (other.gameObject.tag == "Player" && !visited) {
            dialogtext.O();
            visited = true;
        }
    }
}
