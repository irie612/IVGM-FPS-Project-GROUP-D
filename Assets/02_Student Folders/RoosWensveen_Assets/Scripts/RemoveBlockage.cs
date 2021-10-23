using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBlockage : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectsWithTag("Lollipop").Length <= 0) {
        //if(Input.GetKey(KeyCode.Space)) {
            Debug.Log("Done");  
            Destroy(gameObject);
        } 
    }
}
