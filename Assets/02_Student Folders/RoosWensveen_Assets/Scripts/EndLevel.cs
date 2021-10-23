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
                    StartCoroutine(WaitForSceneLoad());
                    //SceneManager.LoadScene(RoosWensveen);
                    //SceneManager.LoadScene("MainMenuScene", LoadSceneMode.Additive);
                }
            } 
        }
    }

private IEnumerator WaitForSceneLoad() {
     yield return new WaitForSeconds(6);
//     SceneManager.LoadScene("MainMenuScene");

     SceneManager.LoadScene("RoosWensveen_Scene");
}
}
