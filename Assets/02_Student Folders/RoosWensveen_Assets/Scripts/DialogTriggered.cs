using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTriggered : MonoBehaviour
{

//DialogText dt = new DialogText();
public DialogText dt;
public DialogText dialogtext;

public GameObject gameObject;
public CharacterController cc;


    void OnTriggerEnter (Collider other) {
        if (other.gameObject.tag == "Player") {
            Debug.Log("hoi");
            //dt.O();
//dialogtext = GetComponent<DialogText>();
//     CharacterController cc = GetComponent<CharacterController>();
//cc.enabled=false;
//Time.timeScale = 0;
dialogtext.O();
//cc.enabled=true;
        }
    }
}
