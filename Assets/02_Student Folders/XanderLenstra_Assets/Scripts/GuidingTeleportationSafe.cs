using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GuidingTeleportationSafe : MonoBehaviour
{
    public Transform player;
    NavMeshAgent nav;
    bool company = false;

    [Tooltip("Max distance before teleport to player")]
    public int teleportDistance = 10;

    [Tooltip("Max distance before follow player")]
    public double followDistance = 0.5;

    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        nav.updateRotation = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, gameObject.transform.position) > teleportDistance)
        {
            nav.enabled = false;
            gameObject.transform.position = player.transform.position + Vector3.back + Vector3.up;
            Physics.SyncTransforms();
            nav.enabled = true;
            nav.SetDestination(player.position);
        }
        if(Vector3.Distance(player.transform.position, gameObject.transform.position) > followDistance || company) {
            company = true;
            nav.SetDestination(player.position);
            if (nav.velocity.normalized != Vector3.zero) {
                transform.rotation = Quaternion.LookRotation(nav.velocity.normalized);
            }
        }
    }
}