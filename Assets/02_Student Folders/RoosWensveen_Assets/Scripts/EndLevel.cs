using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{

    public WinGame wingame;
    public GameObject gameObject;
    bool visited = false;
/*
void Start() {
Debug.Log("....");
}*/

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectsWithTag("Lollipop").Length <= 0) {
            if(GameObject.FindGameObjectsWithTag("Enemy").Length <= 0) {
                if(!visited) {
                    wingame.O();
                    visited = true;
                    //SceneManager.LoadScene(RoosWensveen);
                    SceneManager.LoadScene("RoosWensveen", LoadSceneMode.Additive);
                }
            } 
        }
    }
}
