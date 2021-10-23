using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogMessage2 : MonoBehaviour
{

    public WinGame wingame;
    public GameObject gameObject;
    bool visited = false;

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectsWithTag("Lollipop").Length <= 0) {
            if(!visited) {
                wingame.O();
                visited = true;
            } 
        }
    }
}
