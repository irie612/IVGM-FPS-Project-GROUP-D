using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LollipopCounter : MonoBehaviour
{
    public int counter ; 
public GameObject destroyable;

    // Start is called before the first frame update
    void Start()
    {
      GameObject[] npcs = GameObject.FindGameObjectsWithTag("Lollipop");
      counter = npcs.Length;
      Debug.Log(counter);
    }

    // Update is called once per frame
    void Update()
    {
       if(GameObject.FindGameObjectsWithTag("Lollipop").Length <= 0) {
DestroyImmediate(destroyable);
}
       //Debug.Log(counter);
/*

           Debug.Log("Shot them all");


    //GameObject[] ToBeDestroyed = GameObject.FindGameObjectsWithTag("Blockage");
    //Destroy(ToBeDestroyed);

    //Destroy(GameObject.FindGameObjectsWithTag("Blockage"));


GameObject[] enemies = GameObject.FindGameObjectsWithTag("Blockage");
Debug.Log("Found");
         for(int i=0; i< enemies.Length; i++)
         {
             DestroyObject(enemies[i]);
         }

       }
*/
    }
}
