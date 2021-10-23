using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Guiding1 : MonoBehaviour
{
    public Transform player;
    NavMeshAgent nav;
    bool company = false; 

    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
nav.updateRotation = false;

    }

    // Update is called once per frame
    void Update()
    {
      if(player.position.x - transform.position.x < 0.5 || company) {
      company = true;
      nav.SetDestination(player.position);
      //nav.updateRotation = true;
      //transform.rotation = Quaternion.Euler(player.rotation.eulerAngles.x,180-player.rotation.eulerAngles.y, player.rotation.eulerAngles.z);
if (nav.velocity.normalized != Vector3.zero) {
transform.rotation = Quaternion.LookRotation(nav.velocity.normalized);
}
      }
    }
}
