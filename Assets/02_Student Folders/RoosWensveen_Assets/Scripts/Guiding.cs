using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Guiding : MonoBehaviour
{
    public Transform player;
    NavMeshAgent nav;
    bool company = false;

    [Tooltip("Max distance before teleport to player")]
    public int teleportDistance = 10;

    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        nav.updateRotation = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.position.x - transform.position.x > teleportDistance ||
            player.position.y - transform.position.y > teleportDistance || 
            player.position.z - transform.position.z > teleportDistance)
        {
            gameObject.transform.position = player.transform.position + Vector3.back;
            nav.SetDestination(player.position);
        } 
        if(player.position.x - transform.position.x < 0.5 || company) {
            company = true;
            nav.SetDestination(player.position);
            if (nav.velocity.normalized != Vector3.zero) {
                transform.rotation = Quaternion.LookRotation(nav.velocity.normalized);
            }
        }
    }
}
