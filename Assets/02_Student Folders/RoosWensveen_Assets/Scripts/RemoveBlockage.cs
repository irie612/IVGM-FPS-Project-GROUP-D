using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBlockage : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectsWithTag("Lollipop").Length <= 0) {  
            Destroy(gameObject);    
        } 
    }
}
