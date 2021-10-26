using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beginning : MonoBehaviour
{
    public GameObject[] Script = new GameObject[3];
    public int curFrame = 0;
    public GameObject camera;
    public GameObject cameraScene;
    public GameObject cameraVil;
    public GameObject ktext;
    private bool stop = false;
    public GameObject panel;

    public GameObject wall;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyUp(KeyCode.K) && !stop)
        {
            if (curFrame < Script.Length - 1)
            {
                curFrame += 1;
                Script[curFrame - 1].SetActive(false);
                Script[curFrame].SetActive(true);


                if (curFrame == 2)
                {
                    camera.SetActive(false);
                    cameraVil.SetActive(true);
                }
                if (curFrame == 3)
                {
                    camera.SetActive(true);
                    cameraVil.SetActive(false);
                }


                if (curFrame == 4)
                {
                    camera.SetActive(false);
                    cameraScene.SetActive(true);
                }
                if (curFrame == 5)
                {
                    camera.SetActive(true);
                    cameraScene.SetActive(false);
                }




            }
            else
            {
                Script[curFrame].SetActive(false);
                ktext.SetActive(false);
                stop = true;
                wall.SetActive(false);
                panel.SetActive(false);
            }

        }
    }
}
