using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Objective))]

public class GummyPickupObjective : MonoBehaviour
{
    private Objective m_Objective;
    
    // Start is called before the first frame update
    void Awake()
    {
        m_Objective = GetComponent<Objective>();
        DebugUtility.HandleErrorIfNullGetComponent<Objective, GummyPickupObjective>(m_Objective, this, gameObject);
        
    }

    // Update is called once per frame
    public void PickedUp()
    {
        if(m_Objective.isCompleted)
            return;
        
        m_Objective.CompleteObjective(String.Empty, String.Empty, "Objective complete : " + m_Objective.title);
        
        if (gameObject)
        {
            Destroy(gameObject);
        }
    }
}
