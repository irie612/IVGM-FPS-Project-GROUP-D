using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GummyPickup: MonoBehaviour
{
    private Pickup m_Pickup;
    
    [Tooltip("Enemy Manager that has EnemySpawner component")]
    public EnemySpawner spawner;
    
    // Start is called before the first frame update
    void Start()
    {
        m_Pickup = GetComponent<Pickup>();
        DebugUtility.HandleErrorIfNullGetComponent<Pickup, GummyPickup>(m_Pickup, this, gameObject);
        
        m_Pickup.onPick += OnPicked;
    }

    void OnPicked(PlayerCharacterController player)
    {
        GameObject.Find("GummyBear_Monument").transform.Find("GummyBearEyes").GetComponentInChildren<Renderer>().material.color = Color.red;
        spawner.SetSpawning();
        Destroy(gameObject);
    }
}
