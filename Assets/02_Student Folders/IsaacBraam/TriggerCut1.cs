using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class TriggerCut1 : MonoBehaviour
{
    public PlayableDirector playableDirector;
    public GameObject cookie;
    public GameObject explosion;
    public GameObject explosion2;
    public GameObject explosion3;
    public GameObject switchIn;
    public GameObject camera;
    public GameObject cookieman;
    

    public GameObject[] Script = new GameObject[3];
    public GameObject panel;


    private bool played = false;
    private bool paused = false;
    private Vector3 Pos ;
    public GameObject spot;


    public Transform player1;
    public Transform player2;

    public GameObject tur1;
    public GameObject tur2;
    public GameObject portal;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if(tur1 == null&& tur2 == null)
        {
            portal.SetActive(true);
            explosion3.GetComponent<Exploder>().explosionTime = 1;
            cookieman.SetActive(false);
        }
        if (!paused)
        {
            paused = true;
            playableDirector.Pause();
        }

        if (!played) {
            //float health = cookie.GetComponent<Health>().currentHealth;
            if (cookie == null)//cookie == null
            {
                
                switchIn.SetActive(true);
                //(cookie.GetComponent("EnemyController")).enabled = false;
                //cookie.GetComponent<EnemyController>().enabled = false;
                played = true;
                Debug.Log("D");
                playableDirector.Play();
                StartCoroutine(ExampleCoroutine());

            }
        }
        
    }
    IEnumerator ExampleCoroutine()
    {

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds((float)6.5);
        //After we have waited 5 seconds 
        explosion.GetComponent<Exploder>().explosionTime = 1;
        explosion2.GetComponent<Exploder>().explosionTime = 1;
        StartCoroutine(ExampleCoroutine2());
    }

    IEnumerator ExampleCoroutine2()
    {

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds((float)10);
        Script[0].SetActive(true);
        panel.SetActive(true);
        //After we have waited 5 seconds 
        yield return new WaitForSeconds((float)4);
        Script[0].SetActive(false);
        Script[1].SetActive(true);
        yield return new WaitForSeconds((float)6);
        Script[1].SetActive(false);
        Script[2].SetActive(true);
        yield return new WaitForSeconds((float)4);
        Script[2].SetActive(false);
        panel.SetActive(false);
        player1.position = player2.position;
        
    }


}
