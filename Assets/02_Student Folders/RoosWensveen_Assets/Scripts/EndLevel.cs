using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{

    public WinGame wingame;
    bool visited = false;

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectsWithTag("Lollipop").Length <= 0) {
            if(GameObject.FindGameObjectsWithTag("Enemy").Length <= 0) {
                if(!visited) {
                    wingame.O();
                    visited = true;
                    StartCoroutine(WaitForSceneLoad());
                }
            } 
        }
    }

    private IEnumerator WaitForSceneLoad() {
        yield return new WaitForSeconds(6);
        SceneManager.LoadScene("JialinCho_Scene");
    }
}
